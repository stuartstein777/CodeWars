(ns catalog.core)
(require '[clojure.string :as str])

(defn item->summary [cat-item]
  (let [name (nth (re-find #"(<name>)(.+)(<\/name>)" cat-item) 2)
        price (nth (re-find #"(<prx>)(.+)(</prx>)" cat-item) 2)
        qty (nth (re-find #"(<qty>)(.+)(</qty>)" cat-item) 2)]
    {:name name
     :price price
     :qty qty}))

(defn item->report [{:keys [name price qty]}]
  (str name " > prx: $" price " qty: " qty))

(defn catalog [s article]
  (let [catalog-items (->> s
                           (str/split-lines)
                           (remove #(= "" %))
                           (map item->summary)
                           (filter (fn [i] (boolean (re-find (re-pattern (str "\\b" article "\\b")) (:name i)))))
                           (map item->report)
                           (str/join "\n"))]
    (if (= "" catalog-items)
      "Nothing"
      catalog-items)))