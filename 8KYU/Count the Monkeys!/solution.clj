(ns kata.monkey.count)
(defn monkey-count [n]
  (loop [c 1 counted []]
    (if (>= n c)
      (recur (inc c) (conj counted c))
      counted)))