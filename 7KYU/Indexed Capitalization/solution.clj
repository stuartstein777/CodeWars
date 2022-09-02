(ns indexed-cap.core
  (require [clojure.string :as str]))

(defn solve [s idx]
  (let [idxs (set idx)]
    (apply str (map-indexed (fn [ix i]
                              (if (idxs ix)
                                (str/upper-case (str i))
                                i)) s))))