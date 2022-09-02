(ns kata)

(defn number->digits [num]
  (->> num str (map (comp read-string str))))

(defn tidy-number [n]
  (apply <= (number->digits n)))