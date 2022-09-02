(ns egypt.core
  (:require [clojure.string :as str]))

(defn decimal->ratio [dec]
  (println dec)
  (loop [n dec
         d 1
         i 1]
    (let [nxi (* n i)
          dxi (* d i)]
      (println "n:: " n ", d:: " d ", i:: " i ", n*i:: " nxi)
      (if (== (int (* n i)) (* n i))
        (/ (int nxi) (int dxi))
        (recur n d (* 10 i))))))

(defn get-initial-fraction [s]
  (println "get-initial-fraction:: " s)
  (cond (= "0" s) 0
        (not (str/includes? s "/")) (decimal->ratio (Double/parseDouble s))
        :else (let [split (str/split s #"/")]
                (/ (Integer/parseInt (first split)) (Integer/parseInt (second split))))))

(defn decomp2 [nr dr decomps]
  (cond (or (zero? nr) (zero? dr))
        decomps

        (zero? (rem dr nr))
        (conj decomps (str "1/" (/ dr nr)))

        (zero? (rem nr dr))
        (conj decomps (str nr "/" dr))

        (> nr dr)
        (recur (mod nr dr) dr (conj decomps (str (int (Math/floor (/ nr dr))))))

        :else
        (let [n (int (Math/ceil (/ dr nr)))]
          (recur (- (*' n nr) dr)
                 (*' n dr)
                 (conj decomps (str "1/" n))))))

(defn decompose [r]
  (let [initial-fraction (get-initial-fraction r)]
    (cond (zero? initial-fraction) []
          (not (ratio? initial-fraction)) [(str initial-fraction)]
          :else (map (partial apply str) (decomp2 (numerator initial-fraction) (denominator initial-fraction) [])))))
