(defn score [n]
  (reduce + (take-while #(<= % n) (iterate #(* 2 %) 1N))))
