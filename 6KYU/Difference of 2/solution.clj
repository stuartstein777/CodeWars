(ns difftwo)

(defn twos-difference [xs]
  (->> (mapcat (fn [x] (map (fn [y] [x y]) xs)) xs)
       (filter #(= 2 (Math/abs (- (second %) (first %)))))
       (map set)
       (distinct)
       (map sort)
       (map vec)
       (sort-by first)))