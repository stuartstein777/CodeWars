(ns movie.core)

(defn get-total [card ticket discount n]
  (let [a1 (* ticket discount)]
    (+ card (* a1 (/ (- 1 (Math/pow discount n))
                     (- 1 discount))))))

(defn movie [card ticket discount]
  (loop [count 1]
    (let [a (* count ticket)
          b (get-total card ticket discount count)]
      (if (> (- a b) 1)
        (do
          (int count))
        (recur (inc count))))))