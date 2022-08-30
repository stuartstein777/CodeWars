(ns kata.bus)
(defn number
  [bus-stops]
  (reduce #(+ %1 (- (first %2) (second %2))) 0 bus-stops))