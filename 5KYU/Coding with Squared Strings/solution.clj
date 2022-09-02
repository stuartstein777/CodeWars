(ns coddecsqstrings.core
  (:require [clojure.string :as str]))

(defn diag-1-sym [s]
  (let [rows (str/split s #"\n")
        cnt (count rows)]
    (->> (for [pos (range cnt)] (map #(nth % pos) rows))
         (map (partial apply str)))))

(defn rot-90-clock [s]
  (map (partial apply str) (map reverse (diag-1-sym s))))

(defn rot-90-counter [s]
  (->> (str/split s #"\n")
       (apply map vector)
       (reverse)
       (map (partial apply str))))

(defn code [s]
  (if (= s "")
    ""
    (let [square (->> (count s)
                      (Math/sqrt)
                      (Math/ceil)
                      (int))
          padding (str s (apply str (repeat (- (* square square) (count s)) "\013")))
          squared-string (apply str (apply concat (interpose [\newline] (partition square padding))))]
      (str/join "\n" (rot-90-clock squared-string)))))

(defn decode [s]
  (if (= s "")
    ""
    (str/join "" (map #(str/replace % #"\013" "") (rot-90-counter s)))))