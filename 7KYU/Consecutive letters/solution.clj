(ns consecutive-letters.core)

(defn solve [s]
  (let [sorted (->> (sort s)
                    (map int))]
    (= (range (first sorted) (inc (last sorted))) sorted)))