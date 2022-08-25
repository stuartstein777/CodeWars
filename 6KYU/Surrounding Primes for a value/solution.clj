(ns primebeftaft.core)

(defn is-prime? [n]
  (let [target (Math/sqrt n)]
    (loop [d 2]
      (if (> d target)
        true
        (if (zero? (mod n d))
          false
          (recur (inc d)))))))

(defn prime-before [n]
  (loop [n (dec n)]
    (if (zero? n)
      -1
      (if (is-prime? n)
        n
        (recur (dec n))))))

(defn prime-after [n]
  (if (is-prime? n)
    n
    (recur (inc n))))

(defn prime-bef-aft [n]
  [(prime-before n) (prime-after (inc n))])
