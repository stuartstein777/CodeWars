(ns kata
  (require [clojure.string :as str]))

(defn string-doubles [s]
  (let [s2 (->> (partition-by identity s)
                (mapcat (partial partition-all 2))
                (remove #(= 2 (count %)))
                (flatten)
                (str/join ""))]
    (if (= s2 s)
      s2
      (recur s2))))