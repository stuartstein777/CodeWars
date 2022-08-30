(ns kata
  (:require [clojure.string :as str]))

(defn scorer [game]
  (let [[x y] (->> (str/split game #":")
                   (map (fn [x] (Integer/parseInt x))))]
    (cond (> x y) 3
          (< x y) 0
          (= x y) 1)))

(defn points [games]
  (->> (map scorer games)
       (reduce +)))