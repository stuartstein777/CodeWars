(ns kata)

(defn adjacent-element-product [numbers]
  (->> (map * numbers (rest numbers))
       (apply max)))
