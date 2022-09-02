(ns harmon-point.core)

(defn round [n]
  (let [scale (Math/pow 10 4)]
    (/ (Math/round (* n scale))
       scale)))

(defn harmon-point-trip [a b c]
  (round (/ (- (* 2.0 a b)
               (* a c)
               (* b c))
            (- (+ a b)
               (* 2.0 c)))))