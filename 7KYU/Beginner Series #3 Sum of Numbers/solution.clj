(ns clojure.numbers-sum)

(defn get-sum [a b]
  (->> (range (min a b) (inc (max a b)))
       (reduce +)))