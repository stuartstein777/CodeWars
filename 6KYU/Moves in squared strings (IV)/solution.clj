(ns opstrings1.core
  (:require [clojure.string :as str]))

(defn rot-90-counter [s]
  (->> (str/split s #"\n")
       (apply map vector)
       (reverse)
       (map (partial apply str))))

(defn diag-2-sym [s]
  (->> (str/split s #"\n")
       (apply map vector)
       (map reverse)
       (reverse)
       (map (partial apply str))))

(defn selfie-diag2-counterclock [s]
  (let [s1 (str/split s #"\n")
        s2 (diag-2-sym s)
        s3 (rot-90-counter s)]
    (map (fn [a b c] (str a "|" b "|" c)) s1 s2 s3)))

(defn oper [fct s]
  (str/join "\n" (fct s)))