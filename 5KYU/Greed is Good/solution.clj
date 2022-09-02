(ns kata)

(defn score-partition [total-score part]
  (+ total-score (cond (= '(1 1 1) part) 1000
                       (= '(1 1 1 1) part) 1100
                       (= '(6 6 6) (take 3 part)) 600
                       (= '(5 5 5) (take 3 part)) 500
                       (= '(4 4 4) (take 3 part)) 400
                       (= '(3 3 3) (take 3 part)) 300
                       (= '(2 2 2) (take 3 part)) 200
                       (= '(1 1) part) 200
                       (= '(1) part) 100
                       (= '(5 5) part) 100
                       (= '(5) part) 50
                       :else 0)))


(defn score [rolls]
  (->>
   (group-by identity rolls)
   (vals)
   (reduce score-partition 0)))