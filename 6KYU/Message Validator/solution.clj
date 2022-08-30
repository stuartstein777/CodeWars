(ns message-validator.core)

(defn parse-int [number-string]
  (try (Integer/parseInt number-string)
       (catch Exception e nil)))

(defn valid-message? [s]
  (prn s)
  (->> (partition-by (fn [c] (some? (#{\1 \2 \3 \4 \5 \6 \7 \8 \9 \0} c))) s)
       (map (partial apply str))
       (partition-all 2)
       (map (fn [[c w]] [(parse-int c) w]))
       (every? (fn [[c w]] (= c (count w))))))
