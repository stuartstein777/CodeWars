(ns find-the-odd-int)

(defn find-odd [xs]
  (first (first (filter #(odd? (second %)) (frequencies xs)))))