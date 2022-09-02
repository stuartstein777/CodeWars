(ns summation)

(defn sum-of-n [n]
  (let [abs-seq (reductions + (range (inc (Math/abs n))))]
    (if (neg? n)
      (map - abs-seq)
      abs-seq)))