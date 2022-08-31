(ns ean-validator)

(defn validate-ean [ean-code]
  (loop [digits (butlast (map #(Character/getNumericValue %) ean-code))
         i      false
         s      0]
    (if (empty? digits)
      (if (zero? (mod s 10))
        (= (str (last ean-code)) (str (mod s 10)))
        (= (str (last ean-code)) (str (- 10 (mod s 10)))))
      (recur (rest digits) (not i) (if i
                                     (+ s (* 3 (first digits)))
                                     (+ s (first digits)))))))