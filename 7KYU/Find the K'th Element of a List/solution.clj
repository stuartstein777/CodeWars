(ns element-at)

(defn element-at
  "Find the K'th element of an ISeq"
  [lst n]
  (nth lst (dec n)))