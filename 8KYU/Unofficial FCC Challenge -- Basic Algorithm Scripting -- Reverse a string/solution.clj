(ns clojure.fcc.reverse)

(defn reverse-string [s]
  (apply str (reverse (map identity s))))