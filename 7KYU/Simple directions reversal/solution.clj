(ns kata
  (:require [clojure.string :as str]))

(defn swap-directions [turn]
  (cond (= "Right" turn) "Left"
        (= "Left" turn) "Right"
        :else "Begin"))

(defn reverse-after [n xs]
  (concat (take n xs) (reverse (drop n xs))))

(defn solve [dirs]
  (let [directions (map (fn [d] (str/split d #" on ")) dirs)
        turns (->> (map first directions)
                   (map swap-directions)
                   ((partial reverse-after 1)))
        streets (reverse (map second directions))]
    (map (fn [t s] (str t " on " s)) turns streets)))