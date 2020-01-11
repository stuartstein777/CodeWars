(ns split-str.core)

(defn solution
  [s]
  (->> (if (= 0 (mod (count s) 2))
            s
            (str s "_"))
       (partition-all 2)
       (map (partial apply str))))
	   
;; second solution
(defn solution
  [s]
  (if (= 0 (mod (count s) 3))
    (map (partial apply str) (partition-all 2 (str s "_")))
    (map (partial apply str) (partition-all 2 s))))
	
;; third solution
(defn solution
  [s]
  (let [r (map (partial apply str) (partition-all 2 s))]
    (if (= 1 (count (last r)))
      (assoc (vec r) (dec (count r)) (str (last r) "_"))
      r)))	