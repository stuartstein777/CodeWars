(ns array-diff
  (:require [clojure.set :as set]))

(defn array-diff [a b]
  ((fn [a b diff]
     (if (empty? a)
       diff
       (do (let [x (first a)]
            (if (= nil (some #{x} b))
              (recur (rest a) b (conj diff x))
              (recur (rest a) b diff)))))) a b []))