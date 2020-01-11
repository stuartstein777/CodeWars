(ns banjo
(:require [clojure.string :as str]))

(defn plays-banjo?
  [name]
  (if (= \r (first (str/lower-case name)))
    (str name " plays banjo")
    (str name " does not play banjo")))