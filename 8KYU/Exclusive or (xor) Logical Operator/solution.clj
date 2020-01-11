(ns XOR)

(defn xor [a,b]
    (cond (and (= true a) (= true b)) false
          (and (= true a) (= false b)) true
          (and (= false a) (= true b)) true
          :else false))