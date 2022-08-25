(ns maxsumdig.core)


(defn number->digits [num]
  (->> num str (map (comp read-string str))))

(defn satisfy [maxsm n]
  (let [parts (->> n
                   (number->digits)
                   (partition 4 1)
                   (map #(reduce + %)))]
    (when (every? #(<= % maxsm) parts)
      n)))

(defn closest-to-mean [xs]
  (let [mean (double (/ (reduce + xs) (count xs)))]
    (reduce (fn [acc i]
              (if (< (Math/abs (- mean i))
                     (Math/abs (- mean acc)))
                i
                acc)) Integer/MAX_VALUE xs)))

(defn max-sum-dig [nmax maxsm]
  (let [res (keep (partial satisfy maxsm) (range 1000 (inc nmax)))]

    [(count res)
     (closest-to-mean res)
     (reduce + res)]))