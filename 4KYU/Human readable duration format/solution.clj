(ns human-readable)

(def minute 60)
(def hour (* minute 60))
(def day (* hour 24))
(def year (* day 365))

(defn format-timespan [timespan]
  (cond (= (count timespan) 10) (str (first timespan) " " (second timespan) ", "
                                     (nth timespan 2) " " (nth timespan 3) ", "
                                     (nth timespan 4) " " (nth timespan 5) ", "
                                     (nth timespan 6) " " (nth timespan 7) " and "
                                     (nth timespan 8) " " (nth timespan 9))
        (= (count timespan) 8) (str (first timespan) " " (second timespan) ", "
                                    (nth timespan 2) " " (nth timespan 3) ", "
                                    (nth timespan 4) " " (nth timespan 5) " and "
                                    (nth timespan 6) " " (nth timespan 7))
        (= (count timespan) 6) (str (first timespan) " " (second timespan) ", "
                                    (nth timespan 2) " " (nth timespan 3) " and "
                                    (nth timespan 4) " " (nth timespan 5))
        (= (count timespan) 4) (str (first timespan) " " (second timespan) " and "
                                    (nth timespan 2) " " (nth timespan 3))
        (= (count timespan) 2) (str (first timespan) " " (second timespan))
        (= (count timespan) 0) (str "now")))
        
(defn formatDuration [dur]
  (let [years (/ (- dur (mod dur year)) year)
        minus-years (- dur (* years year))
        days (/ (- minus-years (mod minus-years day)) day)
        minus-days (- minus-years (* days day))
        hours (/ (- minus-days (mod minus-days hour)) hour)
        minus-hours (- minus-days (* hours hour))
        minutes (/ (- minus-hours (mod minus-hours minute)) minute)
        seconds (- minus-hours (* minutes minute))]
    (let [timespan [[years (if (< 1 years) "years" "year")]
                    [days (if (< 1 days) "days" "day")]
                    [hours (if (< 1 hours) "hours" "hour")]
                    [minutes (if (< 1 minutes) "minutes" "minute") ]
                    [seconds (if (< 1 seconds) "seconds" "second")]]
          to-format (vec (flatten (filter #(> (first %) 0) timespan)))]
      (format-timespan to-format))))