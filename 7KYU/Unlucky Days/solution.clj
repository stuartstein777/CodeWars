(ns codewars.core)

(defn get-year [year]
  (if (> 1000 year)
    (str 0 year)
    year))

(defn unluckyDays [year]
  (loop [date (-> (java.time.LocalDate/parse (str (get-year year) "-01-01")))
         unlucky 0]
    (let [day (-> date (.getDayOfMonth))
          day-of-week (-> date (.getDayOfWeek) (str))]
      (if (= (inc year) (-> date (.getYear)))
        unlucky
        (if (and (= day 13) (= day-of-week "FRIDAY"))
          (recur (-> date (.plusDays 1)) (inc unlucky))
          (recur (-> date (.plusDays 1)) unlucky))))))
