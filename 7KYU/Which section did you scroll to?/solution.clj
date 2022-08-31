(ns kata)
(defn get-section-id [scroll sizes]
  (let [sections (reductions + sizes)]
    (if (>= scroll (apply max sections))
      -1
      (count (take-while #(<= % scroll) sections)))))