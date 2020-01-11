(ns clojure.chromosomes)

(defn chromosome-check [sperm]
  (if (= "XY" sperm)
    "Congratulations! You're going to have a son."
    "Congratulations! You're going to have a daughter."))