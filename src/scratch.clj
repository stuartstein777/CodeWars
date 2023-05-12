(ns scratch
  (:require [clojure.string :as str]
            [clojure.set :as set]))

(defn drop-ends [v]
  (concat [(vec (rest (first v)))]
           (butlast (rest v))
           [(vec (butlast (last v)))]))

(defn drop-ends [v]
  (concat
   [(rest (first v))
    (butlast (rest v))
    (butlast (last v))]))

(let [m [[:a :b :c :d]
         [:e :f nil :h]
         [:i :j :k :l]
         [:m :n :o :p]]]
  (->> (drop-ends m)))

(defn draw-top-row [row]
    (str "┌" (str/join (interpose "┬" (repeat (count row) "───"))) "┐"))

(defn draw-bottom-row [row]
  (str "└" (str/join (interpose "┴" (repeat (count row) "───"))) "┘"))

(defn draw-north-walls [row]
  (prn row)
  (let [first-cell (first row)
        middle-cells (butlast (rest row))
        last-cell (last row)]
    (doto (str
           "├"
           (if (:n first-cell) "───" "   ")
           (str/join (interpose "┼" (map #(if (:n %) "───" "   ") middle-cells)))
           (if (:n last-cell) "───" "   ")
           "┤")
      (prn))))

(defn draw-south-walls [row]
  (let [first-cell (first row)
        middle-cells (butlast (rest row))
        last-cell (last row)]
    (str
     "├"
     (if (:n first-cell) "───" "   ")
     (str/join (interpose "┼" (map #(if (:s %) "───" "   ") middle-cells)))
     (if (:n last-cell) "───" "   ")
     "┤")))

(defn draw-east-west-walls [row]
  (str "")
  )

(defn draw-row [row]
  (str/join "\n"
            (concat [(draw-north-walls row)]
                    [(draw-east-west-walls row)]
                    [(draw-south-walls row)])))

(defn draw-middle-rows [rows]
  (prn "middle rows: " rows)
  (str/join 
   "\n"
   (map draw-row rows)
   ))

(let [maze [[{:n true, :e nil,  :s true :w true}{:n true, :e true, :s true, :w nil}{:n true, :e true, :s nil,  :w true}]
            [{:n true, :e nil,  :s nil  :w true}{:n nil,  :e nil,  :s true, :w nil}{:n nil,  :e true, :s true, :w nil}]
            [{:n nil,  :e true, :s true :w true}{:n true, :e nil,  :s true, :w nil}{:n true, :e true, :s true, :w nil}]]
      ]
  (println
   (str/join "\n"
             [(draw-top-row (first maze))
              (draw-middle-rows
               (drop-ends maze))
              (draw-bottom-row (last maze))])))


"┌───┬───┬───┐"
"|0,0 0,1|0,2|"
"├───┼   ┼   ┤"
"|1,0 1,1 1,2|"
"├   ┼───┼───┤"
"|2,0 2,1 2,2|"
"└───┴───┴───┘"


(->> (range 10)
     (map #(str %))
     (map #(str " " %))
     (str/join ""))


(rem 2824 91)
(Math/floor (/ 2824 91.0))

;; -----------------------------------------------------

(defn gcd [a b]
  (if (zero? a)
    b
    (recur (rem b a) a)))

(defn all-co-prime-pairwise? [xs]
  (let [pairs (set (for [x xs
                         y xs
                         :when (not= x y)]
                     [x y]))]
    (every? #(= 1 (gcd (first %) (second %))) pairs)))

(defn fromNb2Str
  [n arr]
  (cond
    (> (reduce * 1 arr) n) "Not applicable"
    (not (all-co-prime-pairwise? arr)) "Not applicable"
    :else
    (as-> arr o
         (map #(str (mod % n)) o)
         (str/join "--" o)
         (str "-" o))))


         

