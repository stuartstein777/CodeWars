(ns clojure.girl-age)

(defn how-old
  [her-old]
  (Integer/parseInt (str (first her-old))))