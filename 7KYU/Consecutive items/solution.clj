(ns kata)

(defn consecutive [arr a b]
  (boolean (some (set [(list a b) (list b a)]) (partition 2 1 arr))))