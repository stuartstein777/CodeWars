(ns strip-comments
(:require [clojure.string :as str]))

(defn strip-comment [comment-chars line]
  (str/trimr (apply str (take-while #(= nil ((set comment-chars) (str %))) line))))
  
(defn strip-comments [code comment-chars]
  (->> (str/split code #"\n")
       (map (partial strip-comment comment-chars))
       (map (partial apply str))
       (str/join "\n")))
       