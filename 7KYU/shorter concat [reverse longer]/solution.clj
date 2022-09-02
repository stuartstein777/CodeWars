(ns ReverseLonger
  (:require [clojure.string :as str]))

(defn reverseLonger
  [a b]
  (if (< (count a) (count b))
    (str a (str/reverse b) a)
    (str b (str/reverse a) b)))