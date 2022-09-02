(ns kata)

(defn number->digits [num]
  (->> num str (map (comp read-string str))))

(defn valid-digit? [n]
  (not (nil? (#{0 1 2 3 4 5} n))))

(defn special-number [number]
  (if (every? valid-digit? (number->digits number))
    "Special!!"
    "NOT!!"))