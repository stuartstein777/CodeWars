(ns exclamation-mark.core)

(defn remove-bang [s]
  (str (apply str (filter #(not= \! %) s))"!"))