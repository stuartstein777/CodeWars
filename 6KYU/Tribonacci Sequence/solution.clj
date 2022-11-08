(ns kata)

(defn tribonacci [[a b c] n]
  (let [trib-iterator (->> [a b c]
                           (iterate (fn [[a b c]] [b c (+ a b c)]))
                           (map first))]
    (take n trib-iterator)))