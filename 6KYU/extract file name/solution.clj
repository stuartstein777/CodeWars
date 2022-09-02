(ns file-name-extractor)

(defn extract-file-name [dirty-file-name]
  (println dirty-file-name)
  (let [r (first (re-seq #"(\d+)_([\w-]+).([\w-]+).(\w+)" dirty-file-name))]
    (str (nth r 2) "." (nth r 3))))