(ns kata)

(defn pentagonal [n]
  (if (<= n 0)
    -1
    (inc (*' (dec n) (/ 5 2) n))))