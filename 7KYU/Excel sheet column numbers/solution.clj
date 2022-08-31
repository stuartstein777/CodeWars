(ns excelsheet.core)

(defn pow [x n]
  (reduce *' (repeat x n)))

(defn title-to-nb [col]
  (reduce + (map-indexed (fn [i a] (* (inc (- (int a) (int \A))) (pow (dec (- (count col) i)) 26))) col)))