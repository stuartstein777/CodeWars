(ns scramblies.core)

(defn scramble [s1 s2]
  (let [s1f (frequencies s1)
        s2f (frequencies s2)]
    (->> (remove (fn [[k v]] (and (some? (s1f k)) (>= (s1f k) v))) s2f)
         (empty?))))