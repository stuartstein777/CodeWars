(ns clojure.collatz)
(defn hotpo [n]
  ((fn [n c] 
    (cond(= 1 n)         c
         (= 0 (mod n 2)) (recur (/ n 2) (inc c))      
         :else           (recur (inc (* n 3)) (inc c)))) n 0))