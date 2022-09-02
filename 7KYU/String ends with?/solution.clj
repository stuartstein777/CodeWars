(ns kata
  (require [clojure.string :as str]))

(defn solution [strng ending]
  (str/ends-with? strng ending))