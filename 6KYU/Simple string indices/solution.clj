(ns kata)

(defn solve [s idx]
  (let [scnt (count s)]
    (if (and (not= \( (nth s idx)) (not= \) (nth s idx)))
      -1
      (loop [idx idx
             stk []]
        (if (= idx scnt)
          -1
          (let [cur (nth s idx)]
            (prn idx cur stk)
            (cond
              (= cur \()
              (recur (inc idx) (conj stk :open))

              (= cur \))
              (cond (empty? stk)
                    -1

                    (empty? (pop stk))
                    idx

                    :else
                    (recur (inc idx) (pop stk)))

              :else
              (recur (inc idx) stk))))))))