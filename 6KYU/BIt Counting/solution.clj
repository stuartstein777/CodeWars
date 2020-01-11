(ns clojure.bit-counting)

(defn count-bits [n]
  (count (filter #(= \1 %) (Integer/toString n 2))))