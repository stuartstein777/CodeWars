(ns max-sequence)

(defn max-sequence [xs]
  (loop [max-found 0
         arr xs]
    (if (empty? arr)
      max-found
      (let [m (apply max (reductions + arr))]
        (recur (if (> m max-found) m max-found) (rest arr))))))

