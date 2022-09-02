(ns powofdigits.core)

(defn number->digits [num]
  (->> num str (map (comp read-string str))))

(defn pow [n pow]
  (reduce * (repeat pow n)))

(defn number-equals-digits-to-pow [po n]
  (let [digits (number->digits n)
        sum    (reduce (fn [a n] (+ a (pow n po))) 0 digits)]
    (= n sum)))

(defn eq-sum-pow-dig [hmax po]
  (->> (range 2 (inc hmax))
       (filter (partial number-equals-digits-to-pow po))))
