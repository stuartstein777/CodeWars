(ns com-denom.core)

(defn gcd [a b]
  (if (zero? b)
    a
    (recur b (mod a b))))

(defn lcmu [a b]
  (/ (* (Math/abs ^long a) (Math/abs ^long b)) (gcd a b)))


(defn convert-fracts [xs]
  (let [numerators (map first xs)
        denoms     (map second xs)
        lcm        (reduce lcmu denoms)]
    (map (fn [n d] [(* n (quot lcm d)) lcm]) numerators denoms)))