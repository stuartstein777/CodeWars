(ns kata.core
  (require [clojure.string :as str]))

(defn encrypt [s]
  (cond (= 1 (count s)) (int (first s))
        (= 2 (count s)) (str (int (first s)) (last s))
        :else           (str (int (first s))
                             (last s)
                             (apply str (rest (butlast (rest s))))
                             (nth s 1))))

(defn encrypt-this [s]
  (->> (str/split s #" ")
       (map encrypt)
       (str/join " ")))