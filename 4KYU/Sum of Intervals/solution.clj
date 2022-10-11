(ns sum-intervals.core)

(defn merge-intervals [[a b] [c d]]
  (cond (> c b)
        [[a b] [c d]]
        (and (>= c a) (>= d b))
        [[a d]]
        (and (>= c a) (<= d b))
        [[a b]]
        :else
        [[a b] [c d]]))

(defn get-size-of-interval [[a b]]
  (- b a))

(defn reduce-intervals [xs]
  (reduce (fn [acc i]
            (let [to-test-merge (last acc)
                  merged (merge-intervals to-test-merge i)]
              (concat (drop-last acc) merged)))
          [(first xs)]
          (rest xs)))

(defn sum-intervals
  [intervals]
  (->> intervals
       (sort-by (juxt first second))
       (reduce-intervals)
       (map get-size-of-interval)
       (reduce +)))