(ns josephusurvivor.core)

(defn josephus-survivor [n k]
  (loop [r 0
         i 1]
    (if (= i (inc n))
      (inc r)
      (recur (mod (+ r k) i) (inc i)))))