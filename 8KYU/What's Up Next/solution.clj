(ns lazy-next)

(defn next-item
  "Returns the value that comes after item in xs or nil"
  [xs item]
  (second (drop-while #(not= item %) xs)))