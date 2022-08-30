(ns kata)

(defn solve [numbers]
  (->> (group-by #(Math/abs %) numbers)
       (vals)
       (filter #(not= 0 (reduce + %)))
       (ffirst)))