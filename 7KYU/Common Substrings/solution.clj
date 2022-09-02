(ns commonsubs.core
  (require [clojure.string :as str]))

(defn substring-test [str1 str2]
  (->> (partition 2 1 (str/lower-case str1))
       (map (partial apply str))
       (some (partial str/includes? (str/lower-case str2)))
       (nil?)
       (not)))