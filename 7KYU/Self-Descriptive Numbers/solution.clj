(ns descriptives.core)

(defn number->digits [num]
  (->> num str (map (comp read-string str))))

(defn self-descriptive? [n]
  (let [digits (number->digits n)
        groups (group-by identity digits)]
    (every? true? (map #(= (nth digits %) (count (groups %)))
                       (range (count digits))))))