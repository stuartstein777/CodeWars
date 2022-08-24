(ns kata
  (require [clojure.string :as str]))

(defn switcheroo [s]
  (-> (str/replace s "a" "x")
      (str/replace "b" "a")
      (str/replace "x" "b")))