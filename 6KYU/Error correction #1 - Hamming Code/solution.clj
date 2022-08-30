(ns kata)

(defn pad-with-zeros [l s]
  (if (< (count s) l)
    (str (apply str (repeat (- l (count s)) "0")) s)
    s))

(defn encode [s]
  (->> s
       (map int)
       (mapcat (fn [n] (->> (Integer/toString n 2)
                            (pad-with-zeros 8))))
       (mapcat (fn [c] (repeat 3 c)))
       (apply str)))

(defn decode [s]
  (->> s
       (partition 3)
       (map (fn [bits]
              (->> bits frequencies (sort-by val >) ffirst)))
       (partition 8)
       (map (fn [bits] (->> (apply str bits)
                            (pad-with-zeros 8)
                            (#(Integer/parseInt % 2))
                            (char))))
       (apply str)))