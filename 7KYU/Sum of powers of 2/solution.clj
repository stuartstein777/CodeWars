(ns kata
  (:require [clojure.string :as str]))

(defn powers [n]
  (loop [result []
         i      1
         binary (->> (Integer/toBinaryString n)
                     (str/reverse)
                     (seq))]
    (if (empty? binary)
      result
      (recur (if (= \1 (first binary)) (conj result i) result) (* 2 i) (rest binary)))))