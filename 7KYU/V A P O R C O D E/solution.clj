(ns kata
  (:require [clojure.string :as str]))

(defn vaporcode [s]
  (->> s
       (str/upper-case)
       (remove #(= % \space))
       (interpose "  ")
       (apply str)))
