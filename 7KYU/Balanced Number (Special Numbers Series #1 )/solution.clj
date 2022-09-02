(ns balanced-number)

(defn number->digits [num]
  (->> num str (map (comp read-string str))))

(defn balanced-num
  [num]
  (let [l (count (str num))
        digits (number->digits num)
        n (cond (even? l) (Math/ceil (/ l 2))
                :else (/ l 2))
        left (reduce + (take (dec n) digits))
        right (if (even? l)
                (reduce + (drop (inc n) digits))
                (reduce + (drop n digits)))]
    (if (= left right)
      "Balanced"
      "Not Balanced")))