(ns gps.core)
(defn gps [s x]
  (println (count x))
  (loop [max 0.0 r (rest x) l (first x)]
    (if (empty? r)
      (int (Math/floor max))
      (let [n (* 60.0 60.0 (/ (- (first r) (float l)) s))]
        (if (> n max)
          (recur n (rest r) (first r))
          (recur max (rest r) (first r)))))))