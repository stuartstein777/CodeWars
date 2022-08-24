(ns kata
  (:require [clojure.string :as str]))

(defn fake-bin [x]
  (-> (str/replace x #"[0-4]" "0")
      (str/replace #"[5-9]" "1")))