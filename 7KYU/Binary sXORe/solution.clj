(ns kata.binary-sxore)

(defn sxore [n]
  (println n)
  (if (= 0 n)
    0
    (let [r (rem (dec n) 4)]
      (cond (= r 0) 1
            (= r 1) (inc n)
            (= r 2) 0
            (= r 3) n))))