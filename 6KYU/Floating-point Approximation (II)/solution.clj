(ns approxinter.core)

(defn round [n]
  (let [scale (Math/pow 10 2)]
    (/ (Math/round (- (* n scale) 0.5))
       scale)))

(defn interp [f l u n]
  (->> (range l u (/ (- u l) n))
       (map (fn [n] (round (f n))))
       (take n)))