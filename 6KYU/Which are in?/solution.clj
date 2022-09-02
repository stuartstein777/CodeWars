(ns which-are-in.core
  (require [clojure.string :as str]))

(defn in-array [coll1 coll2]
  (->>
   (filter (fn [x] (some (fn [y] (str/includes? y x)) coll2)) coll1)
   (distinct)
   (sort)))