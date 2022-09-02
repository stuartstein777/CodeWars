(ns katas.band-name-generator
  (:require [clojure.string :as str]))

(defn generate-band-name [noun]
  (if (= (first noun) (last noun))
    (str/capitalize (str noun (apply str (rest noun))))
    (str "The " (str/capitalize noun))))