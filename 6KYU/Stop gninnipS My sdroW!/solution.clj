(ns clojure.spin-words
  (:require [clojure.string :as str]))

(defn spin-words [s]
  (str/join " " 
            (map (fn [x] (if (< (count x) 5)
                           x
                           (str/reverse x)))
                 (str/split s #" "))))