(ns kata)
(defn max-multiple [d b]
  (apply max (filter #(= 0 (rem % d)) (range 1 (inc b)))))