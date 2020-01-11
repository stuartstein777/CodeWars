(ns kata)
(defn growing-plant [up-speed down-speed desired-height]
  (println up-speed)
  (println down-speed)
  (println desired-height)
  ((fn [day-count current-height]
    (if (>= (+ current-height up-speed) desired-height)
      day-count
      (recur (inc day-count) (- (+ current-height up-speed) down-speed)))) 1 0))