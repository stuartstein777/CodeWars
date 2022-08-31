(ns haskell-array-operations)

(defn head [xs]
  (first xs))

(defn tail [xs]
  (rest xs))

(defn last_ [xs]
  (last xs))

(defn init [xs]
  (butlast xs))