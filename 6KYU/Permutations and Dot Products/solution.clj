(ns minimum-dot)

(defn dot-product [xs ys]
  (reduce + (map * xs ys)))

(defn minDot [xs ys]
  (dot-product (sort xs) (reverse (sort ys))))