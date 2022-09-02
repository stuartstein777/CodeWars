(ns thirteen.core)

(defn number->digits [num]
  (->> num str (map (comp read-string str))))

(defn thirt [n]
  (let [pow-divs [1 10 9 12 3 4]
        res (->> (number->digits n)
                 (reverse)
                 (map (fn [a b] (* a b)) (cycle pow-divs))
                 (reduce +))]
    (if (= n res)
      res
      (recur res))))