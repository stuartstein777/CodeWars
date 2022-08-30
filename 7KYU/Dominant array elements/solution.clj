(ns kata)

(defn solve [numbers]
  (->> (filter (fn [n]
                 (every? #(> (nth numbers n) %) (drop (inc n) numbers))) (range (count numbers)))
       (map (partial nth numbers))))