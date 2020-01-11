(ns arge.core)

(defn nb-year [p0 percent aug p]
  ((fn [p0 percent aug p years]
      (if (> p p0)
        (recur (Math/floor (+ p0 aug (* p0 (/ percent 100)))) percent aug p (inc years))
        years)) p0 percent aug p 0))