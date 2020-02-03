(ns suite2.core)

(defn game [n]
   (let [res (/ (* n n) 2)]
     (if (ratio? res)
       ((juxt numerator denominator) res)
       [res])))