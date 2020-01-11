(ns katas.counting-duplicates
(:require [clojure.string :as str]))

(defn duplicate-count [text]
  (count (filter #(>= (second %) 2) (frequencies (str/lower-case text)))))