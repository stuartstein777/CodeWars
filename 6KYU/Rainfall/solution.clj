(ns rainfall.core
  (require [clojure.string :as str]))

(defn parse-rainfall [data city]
  (->> (str/split data #"\n")
       (map #(str/replace % #":" ","))
       (map #(str/split % #","))
       (filter #(= (first %) city))
       (first)
       (rest)
       (map (fn [month] (->> (str/split month #" ")
                             (second)
                             (read-string))))))

(defn mean [city data]
  (let [rainfall (parse-rainfall data city)]
    (if (empty? rainfall)
      -1
      (/ (reduce + rainfall) (count rainfall)))))

(defn variance [city data]
  (let [rainfall (parse-rainfall data city)]
    (if (empty? rainfall)
      -1
      (let [mean (/ (reduce + rainfall) (count rainfall))]
        (/ (->> (map #(* (- % mean) (- % mean)) rainfall)
                (reduce +))
           (count rainfall))))))
