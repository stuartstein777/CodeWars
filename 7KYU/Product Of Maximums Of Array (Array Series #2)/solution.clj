(ns kata)
(defn max-product [arr size]
  (->> (sort #(> %1 %2) arr)
       (take size)
       (reduce * 1)))