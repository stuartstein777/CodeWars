(ns easyline.core)

;; Calculating a row n in pascals triangle
;; Given n (which represents a row number)
;; Row n columns
;;		1		1
;;		2		1 * n/1
;;		3		1 * (n-1)/2
;;		4		1 * (n-2)/3 ...
;; e.g. for row 5
;;					  1
;;		1 * (5/1) =   5
;;		5 * (4/2) =  10
;;		10 * (3/3) = 10
;;		10 * (2/4) =  5
;;		5 * (1/5) =   1
;;
(defn easy-line [n]
  (println n)
  (loop [last 1 num n den 1 row [1]]
    (if (= 0 num)
      (reduce #(+ % (* %2 %2)) row)
      (let [current (* last (/ num den))]
        (recur current (dec num) (inc den) (conj row current))))))