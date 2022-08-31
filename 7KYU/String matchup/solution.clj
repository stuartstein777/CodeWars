(ns kata)

(defn solve [xs ys]
  (map (fn [y] (count (filter (fn [i] (= i y)) xs))) ys))