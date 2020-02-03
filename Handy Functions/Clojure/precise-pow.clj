(defn int-pow [b ^long ex]
  (loop [acc 1 ex ex]
    (case ex
      0 acc
      (recur (* acc b) (dec ex)))))