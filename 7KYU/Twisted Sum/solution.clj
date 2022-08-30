(ns twisted-sum)

(defn number->digits [num]
  (->> num str (map (comp read-string str))))


(defn compute-sum [n]
  (reduce (fn [acc i]
            (+ acc (reduce + (number->digits i)))) (range 1 (inc n))))