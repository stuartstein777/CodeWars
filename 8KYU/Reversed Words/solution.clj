(ns kata
  (require [clojure.string :as str]))

(defn reverse-words [words]
  (->> (str/split words #" ")
       (reverse)
       (str/join " ")))