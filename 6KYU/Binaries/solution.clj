(ns code-decode.core
  (:require [clojure.string :as str]))

(defn code [num]
  (let [digits (->> num str (map (comp read-string str)))]
    (reduce #(str %1 (let [bin (Integer/toBinaryString %2)]
                         (str (apply str (repeat (dec (count bin)) "0")) "1" bin))) "" digits )))
(defn decode [b]
  (loop [bin b res ""]
    (if (str/blank? bin)
      res
      (let [bits (inc (count (take-while #(not= \1 %) bin)))]
        (recur (subs bin (* 2 bits)) (str res (Integer/parseInt (subs bin bits (* 2 bits)) 2)))))))