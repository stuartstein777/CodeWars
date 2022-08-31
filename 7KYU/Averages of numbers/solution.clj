(ns averages)

(defn averages [ls]
  (if (< (count ls) 2)
    []
    (loop [xs ls
           a (first xs)
           b (second xs)
           avgs []]
      (if (= 1 (count xs))
        avgs
        (recur (rest xs) (first (rest xs)) (second (rest xs)) (conj avgs (/ (+ a b) 2.0)))))))