(ns kata)

(defn minimum-steps [numbers value]
  (->> (sort numbers)
       (reductions +)
       (take-while #(< % value))
       (count)))