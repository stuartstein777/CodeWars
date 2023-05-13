(ns sumdivsq.core)

(defn is-perfect-square? [n]
  (let [sqrt-n (int (Math/sqrt n))]
    (and (integer? sqrt-n)
         (= (* sqrt-n sqrt-n) n))))

(defn sum-of-squared-divisors [n]
  (let [ssd (->> (range 1 (inc (int (Math/sqrt n))))
                 (filter #(= (rem n %) 0))
                 (mapcat (fn [i]
                           (if (not= i (/ n i))
                             [(* i i) (* (/ n i) (/ n i))]
                             [(* i i)])))
                 (reduce +))]
    (when (is-perfect-square? ssd)
      [n ssd])))

(defn list-squared [m n]
  (->> (range m (inc n))
       (map sum-of-squared-divisors)
       (remove nil?)))