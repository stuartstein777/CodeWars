(ns opstrings.core
  (:require [clojure.string :as str]))

(defn vert-mirror [s]
  (->> (str/split-lines s)
       (map (partial reverse))
       (map (partial apply str))
       (str/join "\n")))
       
(defn hor-mirror [s]
  (->> (str/split-lines s)
       (reverse)
       (str/join "\n")))
       
(defn oper [fct s]
  (fct s))