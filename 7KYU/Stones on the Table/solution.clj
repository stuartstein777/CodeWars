(ns kata)

(defn solution [stones]
  (- (count stones) (count (dedupe stones))))