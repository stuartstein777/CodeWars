(ns bookseller.core
  (:require [clojure.string :as str]))
  
(defn total-for-category [stock cat]
  (->> (filter #(= cat (str (first %))) stock)
       (map #(Integer/parseInt (second (str/split % #" "))))
       (reduce +)))

(defn stock-list [stock categories]
  (if (or (empty? stock) (empty? categories))
    []
    (map #(conj [] % (total-for-category stock %)) categories)))