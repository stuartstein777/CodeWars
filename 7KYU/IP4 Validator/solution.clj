(ns clojure.ip-validation
  (:require [clojure.string :as str]))

(defn validate-ip [ip]
  (let [octets (str/split ip #"\.")]
    (and (= 4 (count octets))
              (every? #(and (not= nil (re-matches #"\d+" %))
                                   (<= 0 (Integer/parseInt %) 255)) octets))))