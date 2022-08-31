(ns kata
  (require [clojure.string :as str]))

(defn solve [s]
  (let [u (reduce (fn [a c] (+ a (if (Character/isUpperCase c) 1 0))) 0 s)
        l (- (count s) u)]
    (if (> u l) (str/upper-case s)
        (str/lower-case s))))
