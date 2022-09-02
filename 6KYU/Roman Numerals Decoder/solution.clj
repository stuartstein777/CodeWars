(ns translate-roman-numerals.core)

(def conversions {\I 1 \V 5 \X 10 \L 50 \C 100 \D 500 \M 1000})

(defn translate-roman-numerals [roman]
  (loop [numerals roman
         last nil
         sum 0]
    (let [current (first numerals)]
      (if (empty? numerals)
        sum
        (cond (and (= current \V) (= last \I)) (recur (rest numerals) current (+ sum 3))
              (and (= current \X) (= last \I)) (recur (rest numerals) current (+ sum 8))
              (and (= current \L) (= last \X)) (recur (rest numerals) current (+ sum 30))
              (and (= current \C) (= last \X)) (recur (rest numerals) current (+ sum 80))
              (and (= current \D) (= last \C)) (recur (rest numerals) current (+ sum 300))
              (and (= current \M) (= last \C)) (recur (rest numerals) current (+ sum 800))
              :else                            (recur (rest numerals) current (+ sum (conversions current))))))))