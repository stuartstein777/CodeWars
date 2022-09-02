(ns kata.routes-calculator)

(defn factorial [n]
  (apply *' (range 1 (inc n))))

(defn routes [n]
  (if (neg? n) 0
      (/ (factorial (*' 2 n))
         (*' (factorial n) (factorial (- (*' 2 n) n))))))