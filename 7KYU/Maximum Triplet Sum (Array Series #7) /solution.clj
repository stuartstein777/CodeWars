(ns kata)

(defn max-tri-sum [numbers]
  (->> (sort > numbers)
       (distinct)
       (take 3)
       (reduce +)))