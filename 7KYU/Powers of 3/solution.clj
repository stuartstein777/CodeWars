(ns clojure.powers3)


(defn largest-power [n]
  (if (= n 1)
    -1
    (loop [r 1]
      (if (>= (Math/pow 3 r) n)
        (dec r)
        (recur (inc r))))))