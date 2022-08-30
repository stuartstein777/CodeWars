(ns kata)
(defn trouble [xs target]
  (if (empty? xs)
    [nil]
    (loop [ys  (rest xs)
           res [(first xs)]
           idx 0]
      (if (= idx (dec (count xs)))
        res
        (let [x (last res)
              y (first ys)]
          (prn idx x y)
          (if (= target (+ x y))
            (recur (rest ys) res (inc idx))
            (recur (rest ys) (conj res y) (inc idx))))))))