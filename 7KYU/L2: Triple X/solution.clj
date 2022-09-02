(ns kata
  (require [clojure.string :as str]))

(defn triple-x? [s]
  (let [first-x (str/index-of s "x")]
    (if (or (nil? first-x) (>= first-x (- (count s) 2)))
      false
      (= "xxx" (subs s first-x (+ first-x 3))))))