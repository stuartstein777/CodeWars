(ns kata)
(defn leap-year?
  "Checks whether a given year is a leap year"
  [year]
  (and (zero? (mod year 4))
       (or (not= 0 (mod year 100))
           (zero? (mod year 400)))))
