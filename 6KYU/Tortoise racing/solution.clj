(ns tortoise.core)

(defn to-time [n]
  "n in seconds to [Hours Minutes Seconds]"
  (let [hours (Math/floor (/ n 3600))
        minutes (Math/floor (/ (- n (* 3600 hours)) 60))
        seconds (- n (* hours 3600) (* minutes 60))]
    [(int hours) (int minutes) (int seconds)]))

(defn race [v1 v2 g]
  (if (> v1 v2)
    nil
    (let [a-speed-ft-per-sec (/ v1 3600)
          b-speed-ft-per-sec (/ v2 3600)
          lead-ft g
          diff-ft-per-sec (- b-speed-ft-per-sec a-speed-ft-per-sec)]
      (->> (Math/floor (/ lead-ft diff-ft-per-sec))
           (to-time)))))