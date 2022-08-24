(ns kata)

(defn odd-or-even [xs]
  (if (even? (reduce + xs))
    "even"
    "odd"))