(ns katas.basic-denico
  (:require [clojure.string :as str]))

(defn get-key [key]
  (let [sorted-key (vec (sort key))]
    (map (fn [k] (inc (.indexOf sorted-key k))) key)))

(defn decode [key msg]
  (map (fn [k] (nth msg (dec k) \space)) key))

(defn denico [k m]
  (let [key     (get-key k)
        message (partition (count key) (count key) [\space] m)]
    (->> (map (partial decode key) message)
         (flatten)
         (apply str)
         (str/trim))))