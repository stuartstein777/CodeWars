(ns Slope)  

(defn slope [v]
    (let [delta-x (- (nth v 3) (second v))
          delta-y (- (nth v 2) (first v))]
      (if (= 0 delta-y)
        "undefined"
        (str (/ delta-x delta-y)))))