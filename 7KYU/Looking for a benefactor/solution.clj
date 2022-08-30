(ns newaverage.core)

(defn new-avg [dons avg]
  (println dons " :: " avg)
  (let [b (int (Math/ceil (- (* avg (inc (count dons))) (reduce + dons))))]
    (if (< b 0)
      (throw (IllegalArgumentException. ""))
      b)))