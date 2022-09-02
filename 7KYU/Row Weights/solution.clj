(ns kata)
(defn row-weights [weights]
  (let [xs (reduce + (take-nth 2 weights))
        ys (reduce + (take-nth 2 (rest weights)))]
    [xs ys]))