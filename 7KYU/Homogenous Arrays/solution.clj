(ns kata.filter-homogenous)

(defn filter-homogenous [sq]
  (filter #(and (= (count (partition-by type %)) 1)
                (> (count %) 0)) sq))
