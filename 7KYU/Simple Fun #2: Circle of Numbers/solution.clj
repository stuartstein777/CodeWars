(ns circle-of-numbers)

(defn circle-of-numbers
  [n first-number]
  (mod (+ first-number (/ n 2)) n))