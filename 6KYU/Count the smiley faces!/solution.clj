(ns smiley
(:require [clojure.set :as set]))

(defn valid-smiley? [s]
  (let [valid-eyes #{\; \:}
      valid-noses #{\- \~}
      valid-mouths #{\D \)}]
    (and (not= nil (valid-eyes (first s)))
         (if (= (count s) 2)
           (not= nil (valid-mouths (second s)))
           (do
            (and (not= nil (valid-noses (second s)))
                 (not= nil (valid-mouths (nth s 2)))))))))
                 
(defn count-smileys [arr]
  (count (filter valid-smiley? arr)))