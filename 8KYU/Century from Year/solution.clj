(ns century.core)
(defn century [year]
  (loop [yr year
         c 0]
    (if (< yr 100)
      (if (= yr 0)
        c
        (inc c))
      (recur (- yr 100) (inc c)))))