(ns hidcubic.core
  (require [clojure.string :as str]))

(defn number->digits [num]
  (->> num str (map (comp read-string str))))

(defn is-cubic? [n]
  (let [digits (number->digits n)]
    (= n (reduce (fn [acc i] (+ acc (* i i i))) 0 digits))))

(defn chars->numbers [cs]
  (->> (map str cs)
       (apply str)
       (read-string)))

(defn sum-cubes [s]
  (let [cubics (->> (re-seq #"\d+" s)
                    (mapcat (partial partition-all 3))
                    (map chars->numbers)
                    (filter is-cubic?))]
    (if (empty? cubics)
      "Unlucky"
      (str (str/join #" " cubics) " " (apply + cubics) " Lucky"))))