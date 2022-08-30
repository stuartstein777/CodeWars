(ns voltank.core)

(defn tank-vol [h d vt]
  (let [r (/ d 2.0)
        r-sq (* r r)
        l (/ vt (* Math/PI r-sq))]
    (int
     (Math/floor
      (* l (- (* r-sq
                 (Math/acos (/ (- r h)
                               r)))
              (* (- r h)
                 (Math/sqrt (- (* 2.0 r h)
                               (* h h))))))))))
