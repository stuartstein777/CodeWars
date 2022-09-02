(ns partlist.core
  (:require [clojure.string :as str]))

(defn partlist [xs]
  (->> (map-indexed (fn [ix _] (list (str/join " " (take (inc ix) xs)) (str/join " " (drop (inc ix) xs)))) xs)
       (butlast)))