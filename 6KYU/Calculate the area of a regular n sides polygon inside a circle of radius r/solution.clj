(ns kata)

(defn round [n places]
  (let [scale (Math/pow 10 places)]
    (/ (Math/round (* n scale))
       scale)))

(defn area-of-polygon-inside-circle [r n]
  (round
   (* (/ (* n (* r r))
         2)
      (Math/sin (/ (* 2 Math/PI)
                   n)))
   3))