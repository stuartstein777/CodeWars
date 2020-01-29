(ns bookseller.core
  (:require [clojure.string :as str]))

(defn total-for-category [stock cat]
  (->> (filter #(= cat (str (first %))) stock)
       (reduce (fn [acc i] (+ acc (Integer/parseInt (second (str/split i #" "))))) 0)))
       
(defn stock-list [stock categories]
  (if (or (empty? stock) (empty? categories))
    []
    (map #(conj [] % (total-for-category stock %)) categories)))
	
	