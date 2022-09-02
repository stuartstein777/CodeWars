(ns PowerSetCounting)

(defn factorial [n]
  (apply *' (range 1 (inc n))))

(defn binom
  "calculate binomal coefficient"
  [n k]
  (/ (factorial n)
     (*' (factorial k) (factorial (- n k)))))

(defn powers [xs]
  (inc (reduce + (map (partial binom (count xs)) (range (count xs))))))