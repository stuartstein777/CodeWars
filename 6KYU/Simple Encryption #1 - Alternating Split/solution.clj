(ns alternate-split.kata
  (:require [clojure.string :as str]))

(defn encrypt [st n]
  (if (or (neg? n) (zero? n))
    st
    (recur
     (str (apply str (take-nth 2 (subs st 1)))
          (apply str (take-nth 2 st)))
     (dec n))))

(defn pad [xs]
  (conj xs nil))

(defn decrypt [st n]
  (println st)
  (if (or (neg? n) (zero? n))
    st
    (let [split  (Math/floor (/ (count st) 2))
          s1     (vec (take split st))
          s2     (vec (drop split st))
          ps1    (if (odd? (count st))
                   (pad s1)
                   s1)]
      (recur (apply str (interleave s2 ps1)) (dec n)))))