(ns rentalcarcost.core)

(defn rental-car-cost [d]
  (cond (>= d 7) (- (* d 40) 50)
        (>= d 3) (- (* d 40) 20)
        :else (* d 40)))