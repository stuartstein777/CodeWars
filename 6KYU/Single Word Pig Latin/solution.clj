(ns piglatin
  (:require [clojure.string :as str]))

(defn is-vowel [c]
  (not (nil? (#{\a \e \i \o \u} c))))

(defn pig-latin [s]
  (if (= "" s)
    ""
    (let [s (str/lower-case s)]
      (if (not (nil? (re-find #"\d" s)))
        nil
        (if (is-vowel (first s))
          (str s "way")
          (let [starting-consenants (take-while #(not (is-vowel %)) s)]
            (str/lower-case (str (subs s (count starting-consenants)) (apply str starting-consenants) "ay"))))))))
