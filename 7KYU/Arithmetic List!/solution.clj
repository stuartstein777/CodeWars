(ns seqlist)

(defn seqlist
  "Generates consecutive terms in a sequence"
  [first c terms]
  (loop [n first
         res []]
    (if (= n (+ first (* c (dec terms))))
      (conj res n)
      (recur (+ n c) (conj res n)))))