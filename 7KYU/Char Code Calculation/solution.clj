(ns kata.calc
  (require [clojure.string :as str]))

(defn calc [s]
  (reduce #(if (= \7 %2)
             (+ % 6)
             %) 0 (map identity (apply str (map int s)))))
