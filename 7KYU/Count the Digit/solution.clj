(ns countdig.core
  (:require [clojure.string :as str]))

(defn nb-dig [n d]
  (let [all-digits (->> (range 0 (inc n))
                        (map (partial #(* % %)))
                        (apply str))]
    (- (count all-digits)
       (count (str/replace all-digits (re-pattern (str d)) "")))))