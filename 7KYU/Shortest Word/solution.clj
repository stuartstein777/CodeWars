(ns kata
  (:require [clojure.string :as str]))

(defn find_shortest [words]
  (->> (str/split words #" ")
       (map count)
       (apply min)))