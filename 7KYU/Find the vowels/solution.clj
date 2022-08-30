(ns vowel-indices
  (require [clojure.string :as str]))

(defn vowel-indices [word]
  (let [vowels #{\a \e \i \o \u \y}]
    (->> word
         (str/lower-case)
         (map vector (range (count word)))
         (reduce (fn [acc [i c]]
                   (if (vowels c)
                     (conj acc (inc i))
                     acc)) []))))