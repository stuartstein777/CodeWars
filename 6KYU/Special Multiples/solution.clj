(ns countmultiples.core)

(def prime-products [1N 2N 6N 30N 210N 2310N 30030N 510510N 9699690N 223092870N 6469693230N 200560490130N 7420738134810N 304250263527210N 13082761331670030N 614889782588491410N 32589158477190044730N 1922760350154212639070N])

(defn count-spec-mult [n maxval]
  (let [first-divisible (nth prime-products n)]
    (int (/ maxval first-divisible))))