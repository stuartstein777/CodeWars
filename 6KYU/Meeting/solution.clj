(ns meeting.core)
(require '[clojure.string :as str])

(defn meeting [s]
  (as-> (str/split (str/upper-case o) #";")
        (map #(str/split % #":") o)
        (sort-by (juxt second first) o)
        (map #(str "(" (second %) ", " (first %) ")") o)
        (str/join "" o)))
