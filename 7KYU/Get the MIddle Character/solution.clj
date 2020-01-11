(ns getmiddle.core)

(defn get-middle [word]
  (let [middle-index (Math/floor (/ (count word) 2))]
    (if (even? (count word))
      (str (nth word (dec middle-index)) (nth word middle-index))
      (str (nth word middle-index)))))