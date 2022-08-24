(ns kata)
(defn positive-sum [xs]
  (->> (filter pos? xs)
       (reduce + 0)))