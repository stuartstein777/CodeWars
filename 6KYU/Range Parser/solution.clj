(ns kata.range-parser
  (require [clojure.string :as str]))

(defn get-range [r]
  (let [splits (str/split r #"-|:")]
    (if (= 1 (count splits))
      (Integer/parseInt (first splits))
      (range (Integer/parseInt (first splits))
             (inc (Integer/parseInt (second splits)))
             (Integer/parseInt (nth splits 2 "1"))))))

(defn range-parser [s]
  (->> (str/split s #",")
       (map str/trim)
       (map get-range)
       (flatten)))