(ns maxrot.core
  (:require [clojure.string :as str]))

(defn number->digits [num]
  (->> num str (map (comp read-string str))))

(defn rotations [n]
  (let [digits (number->digits n)]
    (loop [digits digits
           res    [digits]
           n      0]
      (if (= n (dec (count digits)))
        res
        (let [frozen     (take n digits)
              to-rot     (drop n digits)
              new-digits (concat frozen (rest to-rot) [(first to-rot)])]
          (recur new-digits (conj res new-digits) (inc n)))))))


(defn max-rot [n]
  (prn n)
  (->> (rotations n)
       (map (partial drop-while zero?))
       (map (partial apply str))
       (map read-string)
       (apply max)))