(ns quadraticroot.core)

(defn sign [n]
  (if (neg? n)
    -1
    1))

(defn quadratic [a b c]
  (let [x1 (/ (- (- b)
                 (* (sign b) (Math/sqrt (- (* b b) (* 4 a c)))))
              (* 2 a))

        x2 (/ c (* a x1))]
    x2))