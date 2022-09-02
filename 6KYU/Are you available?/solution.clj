(ns are-you-available)

(defn on-or-before [time requested]
  (and (or (zero? (-> time (.compareTo requested)))
           (-> (-> requested (.isAfter time))))))

(defn check-availability [schedule requested]
  (let [schedule (map (fn [t] [(java.time.LocalTime/parse (first t)) (java.time.LocalTime/parse (second t))]) schedule)
        requested (java.time.LocalTime/parse requested)]
    (let [conflict (filter (fn [t] (and (on-or-before (first t) requested)
                                        (-> requested (.isBefore (second t))))) schedule)]
      (if (empty? conflict)
        true
        (-> (second (first conflict)) str)))))