(ns kata)

(defn square-sum [lst]
  (reduce (fn [a i] (+ a (* i i))) 0 lst))