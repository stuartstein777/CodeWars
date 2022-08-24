(ns kata
  (:require [clojure.string :as str]))

(defn high-and-low [s]
  (let [xs (->> (str/split s #" ")
                (map (fn [n] (Integer/parseInt n))))]
    (str (apply max xs) " " (apply min xs))))