(ns kata)

(defn pairs [arr]
  (->> (partition 2 arr)
       (filter (fn [[a b]] (= 1 (Math/abs (- b a)))))
       (count)))