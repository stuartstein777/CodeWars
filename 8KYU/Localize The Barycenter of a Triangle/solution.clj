(ns barycenter.core)

(defn bar-triang [[a b] [c d] [e f]]
  [(Double/parseDouble (format "%.4f" (double (/ (+ a c e) 3)))) 
  (Double/parseDouble (format "%.4f" (double (/ (+ b d f) 3))))])