(ns descending-order)

(defn desc-order [n]
  (Integer/parseInt (apply str (reverse (sort (map identity (str n)))))))