(ns sumdignth.core)

(defn sum-digits [num]
  (->> num
       str
       (map (comp read-string str))
       (reduce +)))

(defn sum-dig-nth-term [init pattern target]
  (let [target (dec target)
        remainder (mod target (count pattern))
        sum (reduce (fn [a i] (+ a (* i (/  (- target remainder) (count pattern))))) 0 pattern)]
    (sum-digits (+ init sum (reduce + (take remainder pattern))))))