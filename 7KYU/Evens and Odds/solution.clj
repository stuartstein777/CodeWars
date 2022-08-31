(ns kata)

(defn evens-and-odds [n]
  (if (even? n)
    (Integer/toBinaryString n)
    (Integer/toHexString n)))