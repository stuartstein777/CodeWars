(ns noboringzeros.core
 (:require [clojure.string :as str]))

(defn no-boring-zeros [n]
  (if (= 0 n)
     0
  (->> (str n)
     (str/reverse)
     (drop-while #(= \0 %))
     (apply str)
     (str/reverse)
     (Integer/parseInt))))