(ns kata.core
  (require [clojure.string :as str]))
  
(defn solve [s]
  [(apply str (map-indexed (fn [i c] (if (odd? i) c (str/upper-case c))) s))  
   (apply str (map-indexed (fn [i c] (if (even? i) c (str/upper-case c))) s))])
