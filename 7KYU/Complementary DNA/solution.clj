(ns complementary-dna
  (:require [clojure.string :as str]))

(defn dna-strand [dna]
  (str/replace dna #"[A|T|C|G]" {"A" "T", "T" "A", "G" "C", "C" "G"}))