(ns valley.core)

(defn make-valley [xs]
  (let [sorted (reverse (sort xs))
        odd (take-nth 2 sorted)
        even (reverse (take-nth 2 (drop 1 sorted)))]
    (concat odd even)))