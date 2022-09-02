(ns rgb.core
  (:require [clojure.string :as str]))

(defn clamp [min max v]
  (cond (< v min) min
        (> v max) max
        :else v))

(defn rgb [r g b]
  (let [rng (partial clamp 0 255)
        r (rng r)
        g (rng g)
        b (rng b)]
    (str/upper-case (str (format "%02x" r) (format "%02x" g) (format "%02X" b)))))