(ns scratch
  (:require [clojure.string :as str]
            [clojure.set :as set]))

(defn divisors [n]
  (->> (range 2 (inc (Math/sqrt n)))
       (filter (fn [d] (zero? (mod n d))))
       (mapcat (fn [d] [d (/ n d)]))
       (set)
       (sort <)))


(divisors 17)
