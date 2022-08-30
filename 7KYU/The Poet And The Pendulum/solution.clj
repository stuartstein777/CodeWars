(ns kata)

(defn pendulum [numbers]
  (let [sorted (sort numbers)
        sol (take-nth 2 (concat (reverse sorted) sorted))]
    (if (even? (count numbers))
      (reverse sol)
      sol)))