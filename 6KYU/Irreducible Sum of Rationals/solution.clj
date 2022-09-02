(ns sumfracts.core)

(defn sum_fracts [l]
  (if (empty? l)
    nil
    (let [result (reduce (fn [acc i] (+ acc (/ (first i) (second i)))) 0 l)]
      (if (integer? result)
        result
        [(numerator result) (denominator result)]))))