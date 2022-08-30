(ns maxdifflength.core)

(defn mxdiflg [a1 a2]
  (if (or (empty? a1) (empty? a2))
    -1
    (let [max-diff-a1-a2 (- (apply max (map count a1)) (apply min (map count a2)))
          max-diff-a2-a1 (- (apply max (map count a2)) (apply min (map count a1)))]
      (if (> max-diff-a1-a2 max-diff-a2-a1)
        max-diff-a1-a2
        max-diff-a2-a1))))