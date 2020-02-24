(ns codewars.puzzle-strings
  (:require [clojure.set :only [map-invert]]))
  
(defn remove-last [c m]
<<<<<<< HEAD
  (dissoc (reduce-kv #(into %1 {%2 (filter (fn [x] (not= x c)) %3)}) {} m) c))
=======
  (dissoc (reduce-kv (fn [acc k v] (into acc {k (filter #(not= % c) v)})) {} m) c))
>>>>>>> ff642283ed292ea624a1b313c745bb54aa9eec77

(defn recover-secret [xs]
  (loop [result ""
         remaining (reduce #(as-> (update %1 (second %2)  conj (first %2)) o
                                  (update o  (nth %2 2)   conj (first %2) (second %2))
                                  (update o  (first %2)   (fnil conj []))) {} xs)]
    (let [next ((map-invert remaining) [])]
      (cond (nil? next) result
            :else (recur (str result next) (remove-last next remaining))))))
