(ns kata.alternate-case
  (:require [clojure.string :as str]))

(defn alternate-case [s]
  (->> (map identity s)
       (map (fn [c] (let [i (int c)]
                      (cond (<= 97 i 122) (str/upper-case (str c))
                            (<= 65 i 90)  (str/lower-case (str c))
                            :else         (str c)))))
       (str/join "")))