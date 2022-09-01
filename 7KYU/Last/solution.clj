(ns last 
  (:refer-clojure :exclude [last]))
            
(defn last
  "Returns the last element of an ISeq"
  [lst]
    (first (reverse lst)))