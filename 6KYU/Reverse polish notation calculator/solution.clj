(ns clojure.reverse-notation
  (:require [clojure.string :as str]))

(defn get-function [i]
  (cond (= i "+") +
        (= i "-") -
        (= i "*") *
        (= i "/") /))

(defn rpn-reducer [operand-stack i]
  (cond (number? i)
        (concat [i] operand-stack)

        :else
        (let [op1 (first operand-stack)
              op2 (second operand-stack)
              res (i op2 op1)]
          (concat [res] (drop 2 operand-stack)))))

(defn evaluate-rpn [rpn]
  (first (reduce rpn-reducer [] rpn)))

(defn tokenize [s]
  (cond
    (some #{\1 \2 \3 \4 \5 \6 \7 \8 \9 \0} s)
    (Double/parseDouble s)

    :else
    (get-function s)))

(defn convert-result [n]
  (if (zero? (mod n 1)) (int n) n))

(defn calc [expr]
  (if (= "" expr)
    0
    (->> (str/split expr #" ")
         (map tokenize)
         (evaluate-rpn)
         (convert-result))))