(ns codewars.puzzle-strings
  (:require [clojure.set :only [map-invert]]))
  
(defn remove-last [c m]
  (dissoc (reduce-kv #(into %1 {%2 (filter (fn [x] (not= x c)) %3)}) {} m) c))

(defn recover-secret [xs]
  (loop [result ""
         remaining (reduce #(as-> (update %1 (second %2)  conj (first %2)) o
                                  (update o  (nth %2 2)   conj (first %2) (second %2))
                                  (update o  (first %2)   (fnil conj []))) {} xs)]
    (let [next ((set/map-invert remaining) [])]
      (cond (nil? next) result
            :else (recur (str result next) (remove-last next remaining))))))