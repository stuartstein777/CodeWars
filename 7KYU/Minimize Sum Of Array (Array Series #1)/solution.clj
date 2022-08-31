(ns kata)

(defn min-sum [xs]
  (let [asc (sort xs)]
    (/ (->> (map #(* %1 %2) asc (reverse asc))
            (reduce +)) 2)))