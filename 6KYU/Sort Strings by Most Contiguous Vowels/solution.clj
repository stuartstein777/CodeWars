(ns contiguous-vowels)

(defn comparer [a b]
  (let [c (compare (:lvc b) (:lvc a))]
    (if (not= c 0)
      c
      (compare (:ori a) (:ori b)))))

(defn longest-contiguos-vowels [{:keys [s]}]
  (let [vcs (->> s
                 (re-seq #"[aeiouAEIOU]+")
                 (map count))]
    (if (seq vcs)
      (apply max vcs)
      0)))

(defn sort-by-vowels [xs]
  (->> xs
       (map (fn [k x] {:ori k :s x}) (range (count xs)))
       (map (fn [i] (assoc i :lvc (longest-contiguos-vowels i))))
       (sort comparer)
       (map :s)))