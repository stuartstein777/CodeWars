(ns kata)

(defn comparer [[val-a freq-a] [val-b freq-b]]
  (cond (> freq-a freq-b) -1
        (< freq-a freq-b) 1
        :else (< val-a val-b)))

(defn solve [numbers]
  (prn numbers)
  (->> numbers
       frequencies
       (sort comparer)
       (reduce (fn [acc [v f]] (concat acc (repeat f v))) [])))