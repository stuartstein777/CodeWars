(ns product-of-fib.core)

(defn product-fib [n]
  ((fn [a b]
     (cond (= n (* a b)) [a b true]
           (> (* a b) n) [a b false]
           :else (recur b (+ a b)))) 0N 1N))