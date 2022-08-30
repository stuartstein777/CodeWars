(ns kata)
(defn solve [s]
  [(count (re-seq #"[A-Z]" s))
   (count (re-seq #"[a-z]" s))
   (count (re-seq #"[0-9]" s))
   (count (re-seq #"[^0-9A-Za-z]" s))])