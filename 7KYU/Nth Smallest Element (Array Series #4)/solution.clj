(ns kata)

(defn nth-smallest [numbers pos]
  (nth (sort numbers) (dec pos)))