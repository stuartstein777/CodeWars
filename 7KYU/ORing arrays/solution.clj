(ns kata)

(defn pad-list [xs def len]
  (concat xs (repeat (- len (count xs)) def)))

(defn or-arrays [a b & [default]]
  (let [default (if (nil? default) 0 default)
        longest (max (count a) (count b))
        xs (pad-list a default longest)
        ys (pad-list b default longest)]
    (map bit-or xs ys)))