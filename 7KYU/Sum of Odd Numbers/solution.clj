(ns row-sum-odd-numbers.core)
(defn row-sum-odd-numbers [x]
  (let [last (+ (* x x) (- x 1))
        start (- last (* 2 (dec x)))]
    (* (/ (+ start last) 2) x)))