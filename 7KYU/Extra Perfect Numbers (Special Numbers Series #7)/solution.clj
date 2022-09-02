(ns kata)

(defn is-extra-perfect? [n]
  (let [bin (Integer/toString n 2)]
    (and (= \1 (first bin)) (= \1 (last bin)))))

(defn extra-perfect [n]
  (->> (range 1 (inc n))
       (filter is-extra-perfect?)))