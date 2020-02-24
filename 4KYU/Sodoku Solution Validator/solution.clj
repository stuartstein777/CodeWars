(ns sudoku
  (:require [clojure.set :as set]))
  
(defn valid-solution [b]
   (and
    (->> (map #(into #{} %) b)
         (every? #(= #{} (set/difference (set (range 1 10)) %))))

    (->> (map (fn [x] (map (fn [y] (nth (nth b y) x)) (range 0 9))) (range 0 9))
         (every? #(= #{} (set/difference (set (range 1 10)) %))))

    (->> (map (partial into #{}) (map flatten (partition 3 (apply interleave (map #(partition 3 %) b)))))
         (every? #(= #{} (set/difference (set (range 1 10)) %)))))
)