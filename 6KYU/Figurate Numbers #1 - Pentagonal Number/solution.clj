(ns pentnum.core)

(defn p-num [n]
  (-> n
      (* 24)
      inc
      Math/sqrt
      inc
      (/ 6)
      (rem 1)
      zero?))

(defn gp-num [n]
  (zero? (rem (Math/sqrt (+ 1 (* 24 n))) 1)))

(defn sp-num [n]
  (and (p-num n) (zero? (rem (Math/sqrt n) 1))))