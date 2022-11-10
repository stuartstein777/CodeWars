(ns only-odd-dig-primes.core)

(defn div? [d n] (zero? (mod n d)))

(defn to-digits [n]
  (->> n str (map (comp read-string str))))

(defn all-odd? [xs]
  (every? odd? xs))

(defn all-odd-digits? [n]
  (-> n
      to-digits
      all-odd?))

(defn is-prime? [n]
  (let [target (Math/sqrt n)]
    (loop [d 2]
      (if (> d target)
        true
        (if (zero? (mod n d))
          false
          (recur (inc d)))))))

(defn pure-odd-prime-after [n]
  (if (and (is-prime? n) (all-odd-digits? n))
    n
    (recur (inc n))))

(defn only-odd-digprime [n]
  (let [all-odd-primes  (->> (range 2 n)
                             (filter is-prime?)
                             (filter all-odd-digits?))]
    [(count all-odd-primes)
     (last all-odd-primes)
     (pure-odd-prime-after n)]))
