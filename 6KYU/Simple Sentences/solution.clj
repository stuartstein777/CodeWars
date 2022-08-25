(ns kata
  (:require [clojure.string :as str]))

(defn make_sentences [parts]
  (prn parts)
  (as-> parts o
    (remove #(= % ".") o)
    (reverse o)
    (drop-while #(= "." %) o)
    (reverse o)
    (interpose " " o)
    (apply str o)
    (str/replace o #"(\s,\s)" (fn [[s & _]] ({" , " ", "} s s)))
    (str o ".")
    (str/replace o " ." ".")))
