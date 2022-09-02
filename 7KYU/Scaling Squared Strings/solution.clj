(ns scalesqstrings.core)
(require '[clojure.string :as str])

(defn scale [s h v]
  (if (= "" s)
    ""
    (->> (str/split-lines s)
         (map #(str/split % #""))
         (map (fn [x] (mapcat (fn [y] (repeat h y)) x)))
         (mapcat #(repeat v %))
         (map (partial apply str))
         (str/join "\n"))))