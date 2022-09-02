(ns nb-triangle.core)

(defn is-triangle-number [number]
  (loop [s 0
         n 1]
    (if (> n number)
      false
      (if (= number (+ s n))
        true
        (recur (+ s n) (inc n))))))