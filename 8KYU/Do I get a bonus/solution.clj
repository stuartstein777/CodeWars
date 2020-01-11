(ns clojure.bonus)

(defn bonus-time [salary bonus]
  (if bonus
    (str "$" (* 10 salary))
    (str "$" salary)))