(ns gcd-sum.core)

(defn gcd [a b]
  (if (zero? b)
    a
    (recur b (mod a b))))

(defn solve [s g]
  (let [y (- s g)]
    (if (= g (gcd g y))
      [g y]
      -1)))