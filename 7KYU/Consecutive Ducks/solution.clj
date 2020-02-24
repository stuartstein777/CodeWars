(ns kata)
(defn consecutive-ducks [n]
  (and (not (zero? n)) (not (zero? (bit-and n (dec n))))))