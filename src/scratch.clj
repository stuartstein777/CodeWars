(ns scratch
  (:require [clojure.string :as str]
            [clojure.set :as set]))

(defn to-digits [n]
  (->> n str (map (comp read-string str))))

(defn all-odd? [xs]
  (every? odd? xs))

(defn all-odd-digits? [n]
  (-> n
      to-digits
      all-odd?))

(defn is-prime? [n]
  (let [target (Math/sqrt n)]
    (loop [d 2]
      (if (> d target)
        true
        (if (zero? (mod n d))
          false
          (recur (inc d)))))))

(let [n 20
      all-odd-primes  (->> (range n)
                           (filter is-prime?)
                           (filter all-odd-digits?))]
  
  
  )