(ns hydrate)
(defn hydrate [drink-string]
  (let [water (->> (re-seq #"\d+" drink-string)
                   (map #(Integer/parseInt %))
                   (reduce + 0))]
    (cond (= 1 water) (str water " glass of water")
          :else (str water " glasses of water"))))