(ns persistent.core)

(defn persistence
  ([n] 
   (if (< n 10)
     0
    (persistence n 1)))
  ([n cnt]
   (let [v (reduce * (->> n str (map (comp read-string str))))]
     (if (< v 10)
       cnt
       (recur v (inc cnt))))))
