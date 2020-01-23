(ns find-the-missing-nuber
  (:require [clojure.set :as set]))

(defn missing-no [xs]
  (println xs)
  (let [all (set (range 0 101))]
    (first (set/difference all (set xs)))))