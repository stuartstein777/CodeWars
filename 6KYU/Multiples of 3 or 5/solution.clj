(ns multiples)

(defn multiple-of-3-or-5? [n]
  (or (= 0 (mod n 3))
      (= 0 (mod n 5))))
      
(defn solution [n]
  (->> (range 1 n)
       (filter multiple-of-3-or-5?)
       (reduce +)))