(ns kata
  (:require [clojure.string :as str]))

(defn draw-stairs [n]
  (str/join "\n" (for [r (range 0 n)]
                   (str (apply str (repeat r " ")) "I"))))