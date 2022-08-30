(ns kata)

(defn flip [d a]
  (cond (= d \R) (sort < a)
        (= d \L) (sort > a)))