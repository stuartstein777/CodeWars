(ns codewars.puzzle-strings
  (:require [clojure.string :as str]))

(defn get-next-char [chars]
  (reduce-kv (fn [acc k v] (if (empty? v) (conj acc k) acc)) [] chars))

(defn remove-last [last cmap]
  "remove all isntances of last from cmap, if the key last is empty, don't add it to the map"
  (reduce-kv (fn [acc k v]
               (if (empty? v)
                 acc
                 (into acc {k (vec (filter #(not= % last) v))}))) {} cmap))

(defn add-triple-to-map [dict triple]
  (as-> (update dict (second triple) conj (first triple)) o
        (update o    (nth triple 2)  conj (first triple))
        (update o    (nth triple 2)  conj (second triple))))

(defn fill-map [dict sec]
  (if (empty? sec)
    dict
    (recur (add-triple-to-map dict (first sec)) (rest sec))))

(defn recover-secret [xs]
  (let [distinct         (distinct (apply str xs))
        chars-map        (apply hash-map (mapcat (fn [k] [k []]) distinct))
        chars-map-filled (fill-map chars-map xs)]
    (loop [remaining chars-map-filled
           result []]
      (let [next (first (get-next-char remaining))]
        (if (nil? next)
          (apply str result)
          (recur (remove-last next remaining) (conj result next)))))))

(secret-string ["tup" "whi" "tsu" "ats" "hap" "tis" "whs"])