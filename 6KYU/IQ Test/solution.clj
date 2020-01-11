(defn unique [str]
  (->> (str/split str #"\s+")
       (map #(Integer/parseInt %))
       (partition-by even?)
       (take-while #(not= (count %) 1))
       (flatten)
       (count)
       (inc)))