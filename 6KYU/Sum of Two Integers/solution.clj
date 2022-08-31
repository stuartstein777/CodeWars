(ns kata)

(defn add [x y]
  (if (zero? y)
    x
    (recur (bit-xor x y) (bit-shift-left (bit-and x y) 1))))