(ns choose1.core)

(defn diagonal [row diag-start]
  (let [symm-row diag-start]
    (loop [last 1
           cur-row (inc symm-row)
           sum 1]
      (if (> cur-row row)
        sum
        (let [element (* last (/ cur-row (- cur-row diag-start)))]
          (recur element (inc cur-row) (+ sum element)))))))