(ns sumconsec.core)

(defn sum-consecutives [a]
  (map (partial reduce +) (partition-by identity a)))