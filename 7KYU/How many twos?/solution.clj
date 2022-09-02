(ns kata.how-many-twos)

(defn solve [n cnt]
  (if (or (zero? n) (odd? n))
    cnt
    (recur (/ n 2) (inc cnt))))

(defn two-count [n]
  (solve n 0))