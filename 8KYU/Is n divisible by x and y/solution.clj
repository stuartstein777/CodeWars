(ns kata)
(defn is-divisible [n x y]
  (and (= 0 (mod n x)) (= 0 (mod n y))))