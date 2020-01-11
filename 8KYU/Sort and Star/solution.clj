(ns clojure.star-sort)

(defn star-sort [arr]
 (apply str (interpose "***" (first (sort arr)))))