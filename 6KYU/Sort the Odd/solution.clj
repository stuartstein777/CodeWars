(ns sort-odd)

(defn sort-array [xs]
  (loop [odds (sort (filter odd? xs))
         sorted []
         n 0
         cnt (count xs)]
    (cond (= n cnt) sorted
          (even? (nth xs n)) (recur odds (conj sorted (nth xs n)) (inc n) cnt)
          :else (recur (rest odds) (conj sorted (first odds)) (inc n) cnt))))