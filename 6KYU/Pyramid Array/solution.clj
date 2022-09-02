(ns kata.pyramid)
(defn pyramid [n]
  (map #(vec (repeat % 1)) (range 1 (inc n))))