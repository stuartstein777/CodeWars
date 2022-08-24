(ns kata)
(defn min-value [digits]
  (->> (distinct digits)
       (sort)
       (apply str)
       (Integer/parseInt)))