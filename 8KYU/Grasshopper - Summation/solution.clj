(ns kata.summation)
(defn summation [n]
  (reduce + (range 1 (inc n))))