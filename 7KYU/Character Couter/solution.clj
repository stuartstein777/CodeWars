(ns validword.core
   (:require [clojure.string :as str]))

(defn validate-word [word]
  (println word)
  (apply = (vals (frequencies (str/lower-case word)))))