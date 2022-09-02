(ns kata)

(defn peak [xs]
  (let [xs1 (reductions + xs)
        xs2 (reductions + (reverse xs))
        res (->> (map (fn [x y] (= x y)) xs1 (reverse xs2))
                 (take-while false?)
                 (count))]
    (if (= (count xs) res)
      -1
      res)))