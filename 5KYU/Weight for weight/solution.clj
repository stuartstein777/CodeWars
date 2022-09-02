(ns weightsort.core
  (require [clojure.string :as str]))

(defn sum-of-digits [num]
  [num (reduce + (->> num str (map (comp read-string str))))])

(defn order-weight [s]
  (->> (str/split s #" ")
       (map sum-of-digits)
       (sort-by (juxt second first))
       (map first)
       (str/join " ")))