(ns jaden-case
  (require [clojure.string :as str]))

(defn jaden-case [s]
  (->> (str/split s #" ")
       (map #(str (str/upper-case (subs % 0 1)) (subs % 1)))
       (str/join " ")))
