(ns perimeter.core)

(def fib (map first (iterate (fn [[a b]] [b (+' a b)]) [4 4])))

(defn perimeter [n]
  (reduce +' 0 (take (inc n) fib)))