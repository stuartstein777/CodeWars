(ns rotations.core
  (:require [clojure.set :as set]))

(defn contain-all-rots [s xs]
  (empty? (set/difference (set (map #(str (apply str (drop % s)) (apply str (take % s))) (range (count s))))
                          (set xs))))