(ns kata.friends)
(defn friends [n]
  (if (<= n 1)
    0
    (dec (int (Math/ceil (/ (Math/log n)
                            (Math/log 2)))))))