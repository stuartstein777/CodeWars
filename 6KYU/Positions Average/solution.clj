(ns pos-average.core)
(require '[clojure.string :as str])

(defn pos-average [s]
  (let [segs (->> (str/split s #",")
                  (map str/trim)
                  (flatten))
        total-combinations (* (count (first segs)) (reduce + (range 1 (count segs))))]
    (* (/ (->> (apply map vector segs)
               (map sort)
               (mapcat (partial partition-by identity))
               (map #(reduce + (range 1 (count %))))
               (reduce +)) total-combinations) 100.0)))