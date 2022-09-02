(ns longest.core)
(require '[clojure.string :as str])

(defn longest [s1 s2]
  (apply str (sort (distinct (str s1 s2)))))