(ns revrot.core)
(require '[clojure.string :as str])

(defn rotate-or-reverse [n]
  (if (zero? (mod (->> (map str n)
                       (map #(Integer/parseInt %))
                       (reduce (fn [acc i] (+ acc (* i i i))) 0)) 2))
    (reverse n)
    (concat (rest n) (list (first n)))))

(defn revrot [s sz]
  (if (or (zero? sz) (zero? (count s)))
    ""
    (->> (partition sz s)
         (mapcat rotate-or-reverse)
         (map str)
         (apply str))))
