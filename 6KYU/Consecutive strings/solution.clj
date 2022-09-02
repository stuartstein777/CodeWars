(ns longest-consec.core
  (require [clojure.string :as str]))

(defn longest-cons [xs k]
  (if (or (<= k 0)
          (zero? (count xs))
          (> k (count xs)))
    ""
    (->> (map-indexed (fn [ix _] (str/join "" (subvec xs ix (+ ix k)))) (range 0 (inc (- (count xs) k))))
         (sort-by count #(> %1 %2))
         (first))))