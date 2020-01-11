(ns nthseries.core)

(defn series-sum [n]
  (loop [total 0
         c 1
         d 1]
    (if (> c n)
      (format "%.2f"(double total))
      (recur (+ total (/ 1.0 d)) (inc c) (+ 3 d)))))