(ns clojure.average)

(defn average [data]
  (if (empty? data)
    0
    (quot (reduce + data) (count data))))