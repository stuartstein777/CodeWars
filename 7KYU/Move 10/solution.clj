(ns kata)

(defn move-ten [st]
  (->> (map #(-> (int %)
                 (- 87)
                 (mod 26)
                 (+ 97)
                 (char)) st)
       (apply str)))