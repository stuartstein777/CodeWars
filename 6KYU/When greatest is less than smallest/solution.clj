(ns kata.when-greatest-is-less-than-smallest)

(defn gcd [a b]
  (if (zero? b)
    a
    (recur b (mod a b))))

(defn abs [n]
  (if (neg? n)
    (- n)
    n))

(defn lcmu [a b]
  (/ (*' (abs a) (abs b)) (gcd a b)))

(defn greatest [x y n]
  (let [z (lcmu x y)
        r (- (+ z (- n (mod n z))) z)]
    (if (>= r n) 0 r)))

(defn smallest [x y n]
  (let [z (lcmu x y)]
    (+ z (- n (mod n z)))))