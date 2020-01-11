(ns kata)
(defn greet [name_ owner]
  (cond (= name_ owner) "Hello boss"
        :else "Hello guest"))