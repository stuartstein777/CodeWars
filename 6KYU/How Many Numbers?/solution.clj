(ns howmany.core)

(defn number->digits [num]
  (->> num str (map (comp read-string str))))

(defn ascending-digits [n]
  (apply < (number->digits n)))

(defn difference-between-digits [d n]
  (let [digits (number->digits n)]
    (->> (map - (rest digits) digits)
         (map #(Math/abs %))
         (every? (fn [n] (<= n d)))
         (boolean))))

(defn sel-number [n d]
  (->> (range 10 (inc n))
       (filter ascending-digits)
       (filter (partial difference-between-digits d))
       (count)))
