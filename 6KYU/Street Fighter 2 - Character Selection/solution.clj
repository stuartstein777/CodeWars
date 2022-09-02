(ns street-fighter)

(defn get-fighter-at-position [fighters pos]
  (let [[x y] pos]
    (nth (nth fighters y) x)))

(defn move-horizontally [x move]
  (let [new-pos (+ x move)]
    (cond (> new-pos 5) 0
          (< new-pos 0) 5
          :else new-pos)))

(defn move-vertically [y move]
  (let [new-pos (+ y move)]
    (cond (neg? new-pos) 0
          (> new-pos 1) 1
          :else new-pos)))

(defn street-fighter-selection [fighters position moves]
  (map (partial get-fighter-at-position fighters)
       (rest (reduce (fn [acc move]
                       (let [x (first (last acc))
                             y (second (last acc))]
                         (cond (= move "up") (conj acc [x (move-vertically y -1)])
                               (= move "down") (conj acc [x (move-vertically y 1)])
                               (= move "right") (conj acc [(move-horizontally x 1) y])
                               (= move "left") (conj acc [(move-horizontally x -1) y])))) [position] moves))))