(ns decode
  (:require [clojure.string :as str]))

(defn decode-bin [b]
  (->> (partition 8 b)
       (map #(char (Integer/parseInt (apply str %) 2)))))

(defn decode-pass [pass-arr bin]
  (let [password (some #{(->> (str/split bin #" ")
                              (map decode-bin)
                              (flatten)
                              (apply str))} pass-arr)]
    (if (= nil password)
      false
      password)))