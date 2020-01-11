(ns kata.lowercase-count)
(defn lowercase_count[strng]
  (count (re-seq #"[a-z]" strng)))