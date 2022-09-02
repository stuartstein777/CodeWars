(ns penultimate)

(defn penultimate
  "Gets the second to last element of an ISeq"
  [lst]
  (last (butlast lst)))