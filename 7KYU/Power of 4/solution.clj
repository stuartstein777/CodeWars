(ns power-of-four)

(defn isPowerOf4? [n]
  (if (zero? n)
    true
    (let [bn (->> (Integer/toBinaryString n)
                  (map identity))]
      (if (= 1 (count (filter #(= \1 %) bn)))
        (even? (count (rest (drop-while #(= \0 %) bn))))
        false))))
