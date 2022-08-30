(ns kata)

(defn div-con [xs]
  (let [int-total (->> (remove string? xs)
                       (reduce +))
        string-total (->> (filter string? xs)
                          (map #(Integer/parseInt %))
                          (reduce +))]
    (- int-total string-total)))