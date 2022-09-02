(ns twosum)
(defn twosum [xs target]
  (->> (map-indexed (fn [ix x] (map-indexed (fn [iix o] [[ix (+ ix (inc iix))] (+ o x)]) (drop (inc ix) xs))) xs)
       (apply concat)
       (filter (fn [f] (= (second f) target)))
       (ffirst)))