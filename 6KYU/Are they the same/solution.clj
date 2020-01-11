(ns aretheysame.core)

(defn compSame [a b]
  (if (or (= nil a) (= nil b))
    false
    (= (sort (map #(* % %) a)) (sort b))))