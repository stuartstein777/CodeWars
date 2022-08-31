(ns summation)

(defn sum [& args]
  "Finds the sum of all of its arguments"
  (reduce + args))