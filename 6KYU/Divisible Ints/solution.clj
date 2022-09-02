(ns divisiblint.core)

(defn number->digits [num]
  (->> num str (map (comp read-string str))))

(defn get-count [n]
  (let [digits     (number->digits n)
        cnt        (count digits)
        substrings (->> (mapcat (fn [n] (partition n 1 digits)) (range 1 cnt))
                        (remove empty?)
                        (map (partial apply str))
                        (map #(Integer/parseInt %))
                        (remove zero?))]
    (->> (map (fn [x] (mod n x)) substrings)
         (filter (fn [x] (zero? x)))
         (count))))