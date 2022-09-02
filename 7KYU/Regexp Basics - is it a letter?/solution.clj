(ns is-it-a-letter)

(defn letter? [s]
  (not= nil (re-matches #"[A-Za-z]" s)))