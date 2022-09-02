(ns funcij.core)

(defn sumin [n]
  (loop [acc 0 i 1 n n]
    (if (zero? n)
      acc
      (recur (+ acc (* i n)) (+ 2 i) (dec n)))))

(defn sumax [n]
  (loop [acc 0
         i (dec (* n 2))
         n n]
    (if (neg? i)
      acc
      (recur (+ acc (* i n)) (- i 2) (dec n)))))

(defn sumsum [n]
  (+ (sumax n) (sumin n)))