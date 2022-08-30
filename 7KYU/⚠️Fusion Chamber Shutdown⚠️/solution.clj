(ns kata)

(defn get-h20 [h o]
  (let [h (quot h 2)]
    (if (>= o h)
      h
      o)))

(defn get-co2 [c o]
  (let [o (quot o 2)]
    (if (>= c o)
      o
      c)))

(defn get-ch4 [c h]
  (let [h (quot h 4)]
    (if (> c h)
      h
      c)))


(defn burner [c h o]
  (let [h2o (get-h20 h o)
        h (- h (* h2o 2))
        o (- o h2o)
        co2 (get-co2 c o)
        c (- c co2)
        o (- o (* 2 co2))
        ch4 (get-ch4 c h)]
    [h2o co2 ch4]))