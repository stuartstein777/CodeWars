(ns longest-vowel.core)

(defn is-vowel [c]
  (not (nil? (#{\a \e \i \o \u} c))))

(defn solve [s]
  (->> (partition-by is-vowel s)
       (filter #(true? (is-vowel (first %))))
       (map count)
       (apply max)))