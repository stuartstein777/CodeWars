(ns kata.core
  (:require [clojure.string :as str]))

(defn encode-dups [word]
  (println word)
  (let [word (str/lower-case word)
        freqs (frequencies word)]
    (reduce (fn [acc i] (str acc (if (= 1 (freqs i)) "(" ")"))) "" word)))