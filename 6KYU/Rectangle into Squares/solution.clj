(ns sq-in-rect.core)

(defn cut-out-square [[w h]]
  (let [smallest-side (min w h)]
    (if (= smallest-side w)
      [smallest-side [w (- h smallest-side)]]
      [smallest-side [(- w smallest-side) h]])))

(defn get-squares [[w h] result]
  (if (or (= 0 w) (= 0 h))
    result
    (let [[square-width new-rect] (cut-out-square [w h])]
      (recur new-rect (conj result square-width)))))

(defn sq-in-rect [lng wdth]
  (if (= lng wdth)
    nil
    (get-squares [lng wdth] [])))
