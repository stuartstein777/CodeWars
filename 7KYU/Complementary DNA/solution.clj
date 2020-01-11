(ns complementary-dna
(:require [clojure.string :as str]))

(defn dna-strand [dna]
  (as-> (str/replace dna "A" "t") v
     (str/replace v "T" "a")
     (str/replace v "C" "g")
     (str/replace v "G" "c")
     (str/upper-case v)))