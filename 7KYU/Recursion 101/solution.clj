(ns kata.core)

(defn solve
  [a b]
  (cond (or (zero? a) (zero? b)) (list a b)
        (>= a (* 2 b)) (recur (- a (* 2 b)) b)
        (>= b (* 2 a)) (recur a (- b (* 2 a)))
        :else (list a b)))