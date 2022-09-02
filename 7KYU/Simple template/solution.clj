(ns clojure.template
  (:require [clojure.string :as str]))

(defn template [s]
  (fn [k]
    (let [rgx         (re-seq #"\{\{(.*?)\}\}" s)
          replacements (map (fn [m] [(first m) (keyword (second m))]) rgx)]
      (prn replacements)
      (loop [i 0
             s s]
        (if (= i (count replacements))
          s
          (recur (inc i) (str/replace s (first (nth replacements i)) (get k (second (nth replacements i)) ""))))))))