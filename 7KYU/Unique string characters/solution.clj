(ns kata)

(defn find-unique [s1 s2]
  (->> (remove #((set s2) %) s1)
       (apply str)))

(defn solve [s1 s2]
  (str (find-unique s1 s2) (find-unique s2 s1)))