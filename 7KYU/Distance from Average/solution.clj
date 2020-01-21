(ns dist2mean.core)

(defn roundTo2 [n] (/ (Math/round (* n 100.0)) 100.0))

(defn distances-from-average [arr]
  (let [avg (/ (reduce + arr) (count arr))] 
    (map #(roundTo2 (- avg %)) arr)
  ))