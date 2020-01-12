(ns play-digits.core)

(defn get-sum [n p]
  (loop [sum    0
         pow    p
         digits (->> n str (map (comp read-string str)))]
    (if (empty? digits)
      sum
      (recur (+ sum (Math/pow (first digits) pow)) (inc pow) (rest digits)))))

(defn dig-pow [n p]
  (let [v (get-sum n p)]
    (if (zero? (mod v n))
      (int (/ v n))
      -1)))