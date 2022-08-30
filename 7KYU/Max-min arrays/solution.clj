(ns kata)

(defn solve [numbers]
  (let [xs (sort numbers)
        ys (sort > numbers)
        res (interleave ys xs)]
    (take (/ (count res) 2) (interleave ys xs))))