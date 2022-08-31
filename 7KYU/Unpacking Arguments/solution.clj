(ns unpack)

(defn spread
  [func args]
  (apply func args))