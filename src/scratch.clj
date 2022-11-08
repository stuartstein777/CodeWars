(ns scratch
  (:require [clojure.string :as str]
            [clojure.set :as set]))

(defn tribonacci [signature n]
  (let [trib-iterator (->> signature
                           (iterate (fn [[a b c]] [b c (+ a b c)]))
                           (map first))]
    (take n trib-iterator)))

(tribonacci [1 1 1] 10)

