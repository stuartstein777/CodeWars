(ns dir-reduc.core
  (:require [clojure.string :as str])) 

(defn dirReduc
  [arr]
  ((fn [directions]
     (let [red (str/replace directions #"NORTHSOUTH|EASTWEST|SOUTHNORTH|WESTEAST" "")]
       (if (= red directions)
           (re-seq #"EAST|NORTH|WEST|SOUTH" red)
           (recur red)))) (str/join "" arr)))