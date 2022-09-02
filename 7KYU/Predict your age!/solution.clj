(ns predicter)
(defn predict-age [& args]
  (as-> (map #(* % %) args) o
    (reduce + o)
    (Math/sqrt o)
    (/ o 2.0)
    (Math/floor o)
    (int o)))