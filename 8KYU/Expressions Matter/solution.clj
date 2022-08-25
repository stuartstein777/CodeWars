(ns expression.matter)

(defn expression-matter [a b c]
  (apply max [(* a (+ b c))
              (* a b c)
              (+ a b c)
              (* (+ a b) c)
              (+ (* a b) c)]))