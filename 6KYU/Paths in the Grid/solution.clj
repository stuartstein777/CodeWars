(ns kata.grid-path)

(defn binom [n k]
  (let [fact #(apply *' (range 1 (inc %)))]
    (/ (fact n)
       (* (fact k) (fact (- n k))))))

(defn number-of-routes [n k]
  (binom (+' n k) k))
