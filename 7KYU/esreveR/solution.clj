(ns reverse
  (:refer-clojure :exclude [reverse]))

(defn reverse
  "Reverse a list"
  [lst]
  ((fn [lst r]
     (if (empty? lst)
       r
       (recur (rest lst) (cons (first lst) r)))) lst []))