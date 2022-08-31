(ns batman.core
  (:require [batman.preloaded :refer [quotes]]))

(defn batman-quotes [quotes hero]
  (let [h (first (keep #(when (Character/isDigit %) %) hero))]
    (println h)
    (cond (= \0 h) (str "Batman: " (first quotes))
          (= \1 h) (str "Robin: " (second quotes))
          (= \2 h) (str "Joker: " (nth quotes 2)))))