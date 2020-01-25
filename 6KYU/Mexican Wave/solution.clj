(ns wave
  (:require [clojure.string :as str]))

(defn wave [s]
  (let [l (dec (count s))]
    (loop [res []
           idx 0]
      (cond (> idx l) (filter #(not= s %) (distinct res))
            (= idx 0) (recur (conj res (str (str/upper-case (subs s 0 1)) (subs s 1))) (inc idx))
            (< idx l) (recur (conj res (str (subs s 0 idx) (str/upper-case (subs s idx (inc idx))) (subs s (inc idx)))) (inc idx))
            (= idx l) (recur (conj res (str (subs s 0 idx) (str/upper-case (subs s idx (inc idx))))) (inc idx))))))