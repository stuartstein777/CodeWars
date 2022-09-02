(ns kata)

(defn max-gap [numbers]
  (as-> (sort numbers) o
    (map (fn [x y] (- y x)) o (rest o))
    (apply max o)))