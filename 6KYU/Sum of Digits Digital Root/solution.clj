(ns digital-root)

(defn digital-root [n]
  (if (< n 10)
    n
    (recur (reduce + (->> n str (map (comp read-string str)))))))