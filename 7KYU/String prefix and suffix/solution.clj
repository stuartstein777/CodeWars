(ns prefix-suffix.core
  (require [clojure.string :as str]
           [clojure.set :as set]))

(defn solve [s]
  (let [post-range (range 0 (inc (quot (count s) 2)))
        suffix-range (range (quot (count s) 2) (count s))
        prefixes (set (map #(subs s 0 %) post-range))
        suffixes (set (map #(subs s %) suffix-range))
        intersections (set/intersection prefixes suffixes)]
    (cond (empty? intersections) 0
          :else (apply max (map count intersections)))))