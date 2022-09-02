(ns affinity)

(defn get-common-count [xs ys cnt]
  (if (or (empty? xs) (empty? ys))
    cnt
    (recur (rest xs) (rest ys) (if (= (first xs) (first ys)) (inc cnt) cnt))))

(defn vector-affinity [xs ys]
  (if (and (empty? xs) (empty? ys))
    1.0
    (float (/ (get-common-count xs ys 0) (max (count xs) (count ys))))))

