(ns katas.unique-in-order)
(defn unique-in-order [input]
  (dedupe input))
  
;; second solution.
(defn unique-in-order [input]
  (map first (partition-by identity input)))