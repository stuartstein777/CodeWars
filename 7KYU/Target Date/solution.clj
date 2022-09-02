(ns dateamount.core)

(defn date-nb-days [a p r]
  (let [daily-interest (/ r (double 36000))]
    (loop [t a
           i 0]
      (if (>= t p)
        (-> (java.time.LocalDate/parse "2016-01-01") (.plusDays i) str)
        (recur (+ t (* daily-interest t)) (inc i))))))