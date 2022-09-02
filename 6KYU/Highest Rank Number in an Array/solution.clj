(ns highest-rank)

(defn highest-rank
  "Returns the most frequent entry in the data ISeq"
  [xs]
  (->> (frequencies xs)
       (sort-by  (juxt second first))
       (last)
       (first)))