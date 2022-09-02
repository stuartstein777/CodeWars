(ns leading-zeros)

(defn zeros [n]
  (loop [i 5.0
         c 0.0]
    (if (< (/ n i) 1)
      (int (Math/floor c))
      (recur (* i 5) (+ c (/ n i))))))