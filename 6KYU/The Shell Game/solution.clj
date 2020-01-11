(ns the-shell-game)

(defn find-the-ball [start swaps]
  (if (empty? swaps)
    start
    (let [x (ffirst swaps)
          y (second (first swaps))]
      (cond (= start x) (recur y (rest swaps))
            (= start y) (recur x (rest swaps))
            :else (recur start (rest swaps))))))
			
;; alternate solution

(ns the-shell-game)

(defn swap [v i1 i2]
  (assoc v i2 (v i1) i1 (v i2)))

(defn find-the-ball [starting-pos swaps]
  "Given the starting position and a list of swaps, find the final position"
  (if (empty? swaps)
    starting-pos
  (loop [cups (assoc (vec (repeat (inc (apply max (flatten swaps))) :#)) starting-pos :O)
         cur-swaps swaps]
    (if (empty? cur-swaps)
      (.indexOf cups :O)
      (recur (swap cups (ffirst cur-swaps) (second (first cur-swaps))) (rest cur-swaps))))))
	  
	  