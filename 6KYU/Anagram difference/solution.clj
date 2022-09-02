(ns anagram
  (require [clojure.set :as set]))

(defn anagram-difference [w1 w2]
  (let [f1 (frequencies w1)
        f2 (frequencies w2)
        all-chars (set/union (set (keys f1)) (set (keys f2)))]
    (reduce (fn [acc i] (+ acc (Math/abs (- (get f1 i 0) (get f2 i 0))))) 0 all-chars)))
