(ns kata.check-for-factor)
(defn check-for-factor [base factor]
  (= 0 (rem base factor)))