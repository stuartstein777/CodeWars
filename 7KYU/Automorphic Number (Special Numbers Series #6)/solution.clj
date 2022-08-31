(ns kata
  (require [clojure.string :as str]))

(defn automorphic [n]
  (if (str/ends-with? (str (* n n)) (str n))
    "Automorphic"
    "Not!!"))