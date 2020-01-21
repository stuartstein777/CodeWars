(ns sum-of-parts.core)

(defn parts-sums [ls]
  (reduce (fn [acc i] (conj acc (+ (first acc) i))) '(0) (into '() ls)))