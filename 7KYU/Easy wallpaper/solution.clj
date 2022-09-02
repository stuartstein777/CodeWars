(ns wallpaper.core)

(defn number->english [n]
  (cond (=  0 n) "zero"
        (=  1 n) "one"
        (=  2 n) "two"
        (=  3 n) "three"
        (=  4 n) "four"
        (=  5 n) "five"
        (=  6 n) "six"
        (=  7 n) "seven"
        (=  8 n) "eight"
        (=  9 n) "nine"
        (= 10 n) "ten"
        (= 11 n) "eleven"
        (= 12 n) "twelve"
        (= 13 n) "thirteen"
        (= 14 n) "fourteen"
        (= 15 n) "fifteen"
        (= 16 n) "sixteen"
        (= 17 n) "seventeen"
        (= 18 n) "eighteen"
        (= 19 n) "nineteen"
        (= 20 n) "twenty"))

(defn wallpaper [l w h]
  (if (and (= 0.0 l) (= 0.0 w) (= 0.0 h))
    "zero"
    (let [total-area-cm (* 100 (+ (* 2 (* 100 w h))
                                  (* 2 (* 100 l h))))]
      (->> (/ total-area-cm 52000)
           (* 1.15)
           (Math/ceil)
           (int)
           (number->english)))))