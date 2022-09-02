(ns english-to-n00b
  (:require [clojure.string :as str]))

(def replacements [[#"fore|Fore|FORE|For|for" "4"] [#"to|too|Too|To" "2"] [#"be" "b"] [#"Be" "B"] [#"know" "no"]
                   [#"Have" "Haz"] [#"have" "haz"] [#"people" "ppl"] [#"People" "Ppl"] [#"really" "rly"]
                   [#"Really" "Rly"] [#"Please" "Plz"] [#"please" "plz"]
                   [#"you" "u"] [#"You" "U"] [#"are" "r"] [#"oo|OO|Oo|oO" "00"] [#"s" "z"] [#"S" "Z"]])

(defn lolify [text]
  (if (or (str/starts-with? text "w") (str/starts-with? text "W"))
    (str "LOL " text)
    text))

(defn count-characters [text]
  (count
   (apply str (re-seq #"[\w\s]+" text))))

(defn omgify [text]
  (if (>= (count-characters text) 32)
    (if (str/starts-with? text "LOL")
      (str (subs text 0 4) "OMG " (subs text 4))
      (str "OMG " text))
    text))


(defn word-count [text]
  (count (str/split text #" ")))

(defn remove-punctuation [text]
  (str/replace text #",|\.|\'" ""))

(defn exclam [text]
  (str/replace text #"\!" (apply str (take (word-count text) (cycle "!1")))))

(defn overdo-question-marks [text]
  (str/replace text #"\?" (apply str (repeat (word-count text) "?"))))

(defn capitalize-even-words [text]
  (->> (str/split text #" ")
       (map-indexed (fn [i w] (if (odd? i) (str/upper-case w) w)))
       (str/join " ")))

(defn uppercase-if-starts-h [text]
  (if (or (str/starts-with? text "h") (str/starts-with? text "H"))
    (str/upper-case text)
    text))

(defn n00bify [text]
  (println text)
  (->> (reduce (fn [acc i] (str/replace acc (first i) (second i))) text replacements)
       (lolify)
       (remove-punctuation)
       (omgify)
       (exclam)
       (overdo-question-marks)
       (capitalize-even-words)
       (uppercase-if-starts-h)))