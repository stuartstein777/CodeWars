(ns kata.triangular-numbers)

(defn is-triangular [t]
  (let [root (Math/sqrt (inc (* 8 t)))]
    (= (inc (* 8 t)) (* (int (Math/ceil root)) (int (Math/ceil root))))))