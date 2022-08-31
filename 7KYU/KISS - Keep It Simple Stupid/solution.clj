(ns kata.is-kiss
  (:require [clojure.string :as str]))

(defn kiss? [s]
  (if (>= (count (str/split s #" "))
          (apply max (map count (str/split s #" "))))
    "Good work Joe!"
    "Keep It Simple Stupid"))
