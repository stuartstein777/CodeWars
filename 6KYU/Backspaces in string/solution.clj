(ns kata
  (require [clojure.string :as str]))

(defn clean-string [s]
  (->> (reduce (fn [acc i]
                 (if (= \# i)
                   (vec (butlast acc))
                   (vec (conj acc i)))) [] s)
       (str/join "")))
