(ns kata
  (:require [clojure.string :as str]))

(defn fill-asterix [s1 s2]
  (prn s1)
  (prn s2)
  (let [[s1b s1a] (str/split s1 #"\*")
        s1-lr (str/index-of s1 "*")
        s1-rl (str/index-of (str/reverse s1) "*")]
    (str s1b (subs s2 s1-lr (- (count s2) s1-rl)) s1a)))

(defn solve [s1 s2]
  (cond (or (= s1 s2)
            (= s1 "*")
            (= s2 (str/replace s1 "*" "")))
        true

        (or (not (str/includes? s1 "*"))
            (> (count s1) (count s2)))
        false

        (= s2 (fill-asterix s1 s2))
        true

        :else
        false))