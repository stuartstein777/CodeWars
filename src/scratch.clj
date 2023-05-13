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


;; -----------------------------------------------------

(defn is-perfect-square? [n]
  (let [sqrt-n (int (Math/sqrt n))]
    (and (integer? sqrt-n)
         (= (* sqrt-n sqrt-n) n))))
  
(defn sum-of-squared-divisors [n]
  (let [ssd (->> (range 1 (inc (int (Math/sqrt n))))
                 (filter #(= (rem n %) 0))
                 (mapcat (fn [i] 
                           (if (not= i (/ n i))
                              [(* i i) (* (/ n i) (/ n i))]
                             [(* i i)])))
                 (reduce +))]
    (when (is-perfect-square? ssd)
      [n ssd])))

(defn list-squared [m n]
    (->> (range m (inc n))
         (map sum-of-squared-divisors)
         (remove nil?)))

(list-squared 1 250)

