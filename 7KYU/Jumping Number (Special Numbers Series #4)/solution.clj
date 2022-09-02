(ns kata)

(defn number->digits [num]
  (->> num str (map (comp read-string str))))

(defn jumping-number [n]
  (let [digits (number->digits n)
        jumping? (->> (map (fn [x y] (= 1 (Math/abs (- x y)))) digits (rest digits))
                      (every? true?))]
    (if jumping?
      "Jumping!!"
      "Not!!")))


