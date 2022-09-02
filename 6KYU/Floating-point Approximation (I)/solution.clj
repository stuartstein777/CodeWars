(ns approxsqrt.core)

(defn f [x]
  (/ x (+ 1N (Math/sqrt (+ 1N x)))))