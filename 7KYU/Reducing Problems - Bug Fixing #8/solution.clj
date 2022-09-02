(ns clojure.calc-total)

(defn calculate_total [t1 t2]
  (> (reduce + t1)
     (reduce + t2)))