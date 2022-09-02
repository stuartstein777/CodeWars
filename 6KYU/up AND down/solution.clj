(ns arrangestring.core
  (require [clojure.string :as str]))

(defn swap-m-with-n [xs a b]
  (concat (take a xs) [(nth xs b)] [(nth xs a)] (drop (inc b) xs)))

(defn swap-dir [f]
  (if (= f <=) >= <=))

(defn arrange-str [xs]
  (loop [xs xs
         i 0
         oper <=]
    (if (= i (dec (count xs)))
      xs
      (if (not (oper (count (nth xs i)) (count (nth xs (inc i)))))
        (recur (swap-m-with-n xs i (inc i)) (inc i) (swap-dir oper))
        (recur xs (inc i) (swap-dir oper))))))

(defn arrange [s]
  (->> (str/split s #" ")
       (arrange-str)
       (map-indexed (fn [ix i] (if (even? ix) (str/lower-case i) (str/upper-case i))))
       (str/join " ")))