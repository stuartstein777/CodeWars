(ns kata)

(defn repeats [xs]
  (reduce (fn [acc [val occurrences]]
            (if (= 1 occurrences) (+ acc val) acc)) 0 (frequencies xs)))