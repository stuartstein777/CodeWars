(ns share-price.core)

(defn share-price [invested changes]
  (if (empty? changes)
    (str invested ".00")  ;; stupid test
    (format "%.2f" (last (reductions #(+ % (/ (* % %2) 100.0)) invested changes)))))