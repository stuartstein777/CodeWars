(ns Pangram
  (:require [clojure.string :refer [lower-case]]))

(defn pangram?
  [s]
  (->> (lower-case s)
       (re-seq #"[a-z]")
       set
       count
       (= 26)))