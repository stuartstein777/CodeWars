(ns kata)
(defn odd-row [n]
  (let [last (+ (* n n) (dec n))
        start (- last (* 2 (dec n)))]
    (range start (inc last) 2)))