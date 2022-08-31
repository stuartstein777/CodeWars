(ns kata)

(defn digitize
  [n]
  (->> n str (map (comp read-string str))))