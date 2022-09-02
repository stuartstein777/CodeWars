(ns Hamming)

(defn hamming [s1 s2]
  (loop [s1 s1 s2 s2 i 0]
    (if (empty? s1)
      i
      (if (not= (first s1) (first s2))
        (recur (rest s1) (rest s2) (inc i))
        (recur (rest s1) (rest s2) i)))))