(ns kata)

(defn number->digits [num]
  (->> num str (map (comp #(Integer/parseInt %) str))))

(defn number->digits [num]
  (->> num str (map (comp #(Integer/parseInt %) str))))

(defn next-happy-year [year]
  (let [year (inc year)
        year-digits (number->digits year)
        distinct-digits (->> year-digits
                             (distinct)
                             (count))]
    (if (= (count year-digits) distinct-digits)
      year
      (recur year))))