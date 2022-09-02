(ns sections.core)

(defn solve [^double n]
  (let [xy (*' n n n)
        s (Math/sqrt xy)]
    (loop [x 1.0 solutions 0]
      (if (> x s)
        solutions
        (if (zero? (mod xy x))
          (let [y (/ xy x)]
            (if (= x y)
              (recur (inc x) (inc solutions))
              (recur (inc x) (+ 2 solutions))))
          (recur (inc x) solutions))))))
          
(defn c [n] (solve (Math/sqrt n)))