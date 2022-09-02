(ns kata.sort-the-inner-content
  (:require [clojure.string :as str]))

(defn sort-inner [text]
  (if (< (count text) 2)
    [text text]
    [text (str (first text)
               (apply str (reverse (sort (butlast (rest text)))))
               (last text))]))

(defn sort-the-inner-content [words]
  (->> (re-seq #"\w+" words)
       (map sort-inner)
       (reduce (fn [acc re] (str/replace acc (first re) (second re))) words)))