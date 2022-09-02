(ns kata)

(defn array-leaders [numbers]
  (->> (range (count numbers))
       (filter (fn [n] (> (nth numbers n) (->> (drop (inc n) numbers)
                                               (reduce +)))))
       (map (fn [n] (nth numbers n)))))