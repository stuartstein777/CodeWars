(ns kata
  (:require [clojure.string :as str]))

(defn is-alphabetical [idx c]
  (= (nth "abcdefghijklmnopqrstuvwxyz" idx) c))

(defn alphabetical-chars [s]
  (->> s
       str/lower-case
       (map-indexed is-alphabetical)
       (filter true?)
       (count)))

(defn solve [xs]
  (map alphabetical-chars xs))