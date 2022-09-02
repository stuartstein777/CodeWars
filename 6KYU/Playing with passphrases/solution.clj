(ns playpass.core
  (require [clojure.string :as str]))

(defn circular-shift [n c]
  (if-let [d (cond (<= 97 (int c) 122) 97
                   (<= 65 (int c) 90)  65)]
    (as-> (int c) o
      (- o d)
      (+ n o)
      (mod o 26)
      (+ o d)
      (char o))
    c))

(defn offset-numbers [s]
  (str/replace s #"\d" #(str (- 9 (Integer/parseInt %)))))

(defn play-pass [s n]
  (->> (map identity s)
       (map (partial circular-shift n))
       (map-indexed #(if (odd? %)
                       (str/lower-case (str %2))
                       (str/upper-case (str %2))))
       (str/join #"")
       (offset-numbers)
       (str/reverse)))