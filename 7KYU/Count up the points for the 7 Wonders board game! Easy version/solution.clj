(ns seven-wonders)
(defn seven-wonders-science [c g t]
  (+ (* (first (sort [c g t])) 7) (* c c) (* g g) (* t t)))