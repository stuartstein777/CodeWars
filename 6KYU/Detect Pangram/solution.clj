(ns Pangram
  (:require [clojure.string :as str]
            [clojure.set :as set]))

(defn pangram?
  [s]
  (= (count (->> (str/lower-case s)
                 (re-seq #"[A-Za-z]")
                 (set))) 26))
