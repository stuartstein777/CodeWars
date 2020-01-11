(ns clojure.string-repeat)

(defn repeat-str [n strng]
  (apply str (repeat n strng)))