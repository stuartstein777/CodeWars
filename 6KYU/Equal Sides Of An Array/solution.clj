(ns findeven.core)

(defn find-even-index [arr]
  (loop [n 0]
  (if (= n (count arr))
    -1
    (if (= (reduce + (subvec arr 0 n))
           (reduce + (subvec arr (inc n))))
        n
        (recur (inc n))))))