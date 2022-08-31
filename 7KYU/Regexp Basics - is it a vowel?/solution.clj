(ns kata.regex-vowel)
(defn vowel [str]
  (println str)
  (not= nil (#{"a" "e" "i" "o" "u" "A" "E" "I" "O" "U"} str)))