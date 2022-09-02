(ns kata.lucas-numbers)

(def lucas-generator
  ((fn lcs [a b]
     (lazy-seq (cons a (lcs b (+' b a))))) 2 1))

(defn lucasnum [n]
  (let [res (first (drop (Math/abs n) lucas-generator))]
    (if (and (neg? n) (odd? (Math/abs n)))
      (- res)
      res)))