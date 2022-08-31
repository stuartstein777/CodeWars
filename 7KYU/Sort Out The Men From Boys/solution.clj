(ns kata)
(defn men-from-boys [arr]
  (let [split ((juxt filter remove) even? (distinct arr))]
    (concat (sort < (first split)) (sort > (second split)))))