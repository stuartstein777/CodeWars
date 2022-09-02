(ns kata)

(defn number->digits [num]
  (->> num str (map (comp read-string str))))

(defn pow [n pow]
  (reduce * (repeat pow n)))

(defn disarium-number [number]
  (if (= number (as-> (number->digits number) o
                  (map (fn [n e] (pow n e)) o (range 1 (inc (count o))))
                  (reduce + o)))
    "Disarium !!"
    "Not !!"))