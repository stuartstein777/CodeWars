(ns digitizer.core)

(defn digitize [n]
  (reverse (map #(Character/digit % 10) (str n))))