(ns HumanTime)

(defn human-readable [x]
  (let [hours (quot x 3600)
        mins (quot (- x (* 3600 hours)) 60)
        secs (- x (* hours 3600) (* mins 60))]
    (str (format "%02d:%02d:%02d" hours mins secs))))