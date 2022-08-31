(ns skin-a-cat)

(defn sum
  ([a b] (+ a b))
  ([a] (fn [b] (+ a b))))