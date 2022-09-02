(ns kata.late-ride)
(defn late-ride [n]
  (let [hours (quot (- n (rem n 60)) 60)
        minutes (rem n 60)]
    (+
     (reduce + (->> hours str (map (comp read-string str))))
     (reduce + (->> minutes str (map (comp read-string str)))))))
