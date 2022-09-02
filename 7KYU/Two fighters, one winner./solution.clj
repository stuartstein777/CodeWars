(ns clojure.two-fighters
  (:require [clojure.two-fighters-preloaded :refer [->Fighter]]))

(defn declare-winner [f1 f2]
  (cond (or (neg? (:hp f1)) (zero? (:hp f1))) (:name f2)
        (or (neg? (:hp f2)) (zero? (:hp f2))) (:name f1)
        :else (recur (->Fighter (:name f1) (- (:hp f1) (:attack f2)) (:attack f1))
                     (->Fighter (:name f2) (- (:hp f2) (:attack f1)) (:attack f2)))))