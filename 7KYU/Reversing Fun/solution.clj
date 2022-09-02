(ns reversefun.core
  (:require [clojure.string :as str]))

(defn reverse-fun [s]
  (let [l (take (Math/ceil (/ (count s) 2)) (str/reverse s))
        r (take (Math/floor (/ (count s) 2)) s)
        res (apply str (interleave l r))]
    (if (odd? (count s))
      (str res (last l))
      res)))