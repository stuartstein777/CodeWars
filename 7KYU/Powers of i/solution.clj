(ns kata.powers-of-i)

(defn pofi [n]
  (let [rem (mod n 4)]
    (cond (= 0 rem) "1"
          (= 1 rem) "i"
          (= 2 rem) "-1"
          (= 3 rem) "-i")))