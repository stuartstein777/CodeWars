(ns getnames)

(defn get-names [data]
  (map #(:name %) data))