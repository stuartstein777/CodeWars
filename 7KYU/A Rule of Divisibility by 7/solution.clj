(ns divpar7.core)

(defn seven [m]
  (loop [n m
         steps 0]
    (if (< (count (str n)) 3)
      [n steps]
      (recur (- (quot n 10) (*' 2 (mod n 10))) (inc steps)))))
