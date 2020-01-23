(ns accumule.core
  (:require [clojure.string :as str]))

(defn accum [s]
  (str/join "-" (map #(str/capitalize (apply str (repeat %2 % ))) s (range 1 (inc (count s))))))