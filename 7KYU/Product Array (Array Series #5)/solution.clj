(ns kata)
(defn product-array [numbers]
  (map-indexed (fn [ix i] (reduce * (concat (drop (inc ix) numbers) (take ix numbers)))) numbers))