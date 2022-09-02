(ns compsqstrings.core
  (:require [clojure.string :as str]))

(defn compose [s1 s2]
  (let [s1 (str/split-lines s1)
        s2 (str/split-lines s2)
        sq (count s1)]
    (->> (map flatten
              (for [r (range 0 sq)]
                [(take (inc r) (nth s1 r)) (take (- sq r) (nth s2 (- sq (inc r))))]))
         (map (partial apply str))
         (str/join "\n"))))