(ns kata)

(defn triangular [n]
  (if (pos? n)
    (/ (* n (+ n 1)) 2)
    0))