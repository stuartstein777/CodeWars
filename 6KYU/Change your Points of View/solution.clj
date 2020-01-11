(ns running-lambda.core)

(defn point [a b]
   (fn [] [a b]))
  
(defn fst [point]
  (first (point)))
  
(defn snd [point]
  (second (point)))
  
(defn sqr-dist [point1 point2]
  (let [delta-x (Math/abs (- (fst point2) (fst point1)))
        delta-y (Math/abs (- (snd point2) (snd point1)))]
        (+ (* delta-x delta-x) (* delta-y delta-y))))
        
(defn line [foo bar]
  [(- (snd foo) (snd bar))
   (- (fst bar) (fst foo))
   (- (* (fst foo) (snd bar))
         (* (snd foo) (fst bar)))])