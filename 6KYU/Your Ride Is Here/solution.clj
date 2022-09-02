(ns comet-fan)

(defn score [word]
  (->> (map identity word)
       (map #(- (int %) 64))
       (reduce *)))

(defn ride
  "Returns GO if the group gets to go and STAY otherwise"
  [group comet]
  (if (= (mod (score group) 47)
         (mod (score comet) 47))
    "GO"
    "STAY"))