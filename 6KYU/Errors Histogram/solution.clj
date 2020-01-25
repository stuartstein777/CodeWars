(ns hist-error.core
  (:require [clojure.string :as str]))

(defn build-error [k v]
  (str k "  " v (apply str (repeat (- 6 (count (str v))) " ")) (apply str (repeat v "*"))))
  
(defn hist [s]
  (str/join "\r" (->> (filter #(#{\u \w \x \z} %) s)
                      (frequencies)
                      (reduce-kv (fn [acc k v] (conj acc (build-error k v))) [])
                      (sort))))