(ns number-of-squares)

(defn get-number-of-squares [n]
  (count (take-while #(> n (second %)) (iterate (fn [[a b]] [(inc a) (+ b (* (inc a) (inc a)))]) [1 1]))))