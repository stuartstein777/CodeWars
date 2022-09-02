(ns kata)

(defn index-finder [l xs]
  (inc (.indexOf (rest l) xs)))