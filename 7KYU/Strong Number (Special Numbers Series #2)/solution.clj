(ns kata)

(defn factorial
  ([n] (factorial n 1))
  ([n sum]
   (cond (= 0 n) sum
         :else (recur (dec n) (* sum n)))))

(defn strong [n]
  (if (= n
         (->> n str
              (map (comp read-string str))
              (map factorial)
              (reduce +)))
    "STRONG!!!!"
    "Not Strong !!"))