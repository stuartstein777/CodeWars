(ns dir-reduc.core
  (:require [clojure.string :as str])) 

(defn reduce-directions [xs]
  ((fn [directions]
     (let [reduction (str/replace directions #"NORTHSOUTH|EASTWEST|SOUTHNORTH|WESTEAST" "")]
       (if (= reduction directions)
           (re-seq #"EAST|NORTH|WEST|SOUTH" reduction)
           (recur reduction)))) (apply str xs)))