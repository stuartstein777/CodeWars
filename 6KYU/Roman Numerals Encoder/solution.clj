(def roman-numerals
  (sorted-map-by >
                 1    "I"
                 4    "IV"
                 5    "V"
                 9    "IX"
                 10   "X"
                 40   "XL"
                 50   "L"
                 90   "XC"
                 100  "C"
                 400  "CD"
                 500  "D"
                 900  "CM"
                 1000 "M"))

(defn solution [n]
  (loop [rn-idx 0
         n n
         result ""]
    (if (= 0 n)
      result
      (let [rn (nth (keys roman-numerals) rn-idx)
            q (quot n rn)]
        (recur
         (inc rn-idx)
         (mod n rn)
         (str result (apply str (repeat q (roman-numerals rn)))))))))