(ns Merge)

(defn mergesorted
  [[a-x & a-xs :as a] [b-x & b-xs :as b]]
  (concat a b))