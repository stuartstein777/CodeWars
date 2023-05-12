(ns moduli.core
  (:require [clojure.string :as str]))

(defn gcd [a b]
  (if (zero? a)
    b
    (recur (rem b a) a)))

(defn all-co-prime-pairwise? [xs]
  (let [pairs (set (for [x xs
                         y xs
                         :when (not= x y)]
                     [x y]))]
    (every? #(= 1 (gcd (first %) (second %))) pairs)))

(defn fromNb2Str
  [n arr]
  (cond
    (< (reduce * 1 arr) n) "Not applicable"
    (not (all-co-prime-pairwise? arr)) "Not applicable"
    :else
    (as-> arr o
      (map #(str (mod n %)) o)
      (str/join "--" o)
      (str "-" o "-"))))