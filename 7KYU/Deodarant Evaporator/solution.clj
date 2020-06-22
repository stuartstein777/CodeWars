(ns evaporator.core)

(defn get-evaporated-content [content evap-per-day]
  (* content (/ evap-per-day 100)))

(defn evaporator [content, evap_per_day, threshold]
  (let [target-content (* content (/ threshold 100))]
    (loop [current-content content
            days 1]
      (let [evaporated-content (get-evaporated-content current-content evap_per_day)]
        (if (< (- current-content evaporated-content) target-content)
          days
          (recur (- current-content evaporated-content) (inc days)))))))
