(ns mixin.core
  (require [clojure.string :as str]
           [clojure.set :as set]))

(defn repeat-char-count-times [count char]
  (apply str (repeat count char)))

(defn get-lower-case-chars [s]
  (apply str (re-seq #"[a-z]+" s)))

(defn get-frequencies-of-common-chars [common-chars s]
  (->> (frequencies s)
       (filter (fn [i] (some common-chars i)))))

(defn comparer [[count-a str-a a] [count-b str-b b]]
  (cond (= count-a count-b)
        (cond (= a b)
              (< (int str-a) (int str-b))
              (> a b) 1
              :else -1)
        (> count-a count-b) -1
        :else 1))

(defn pre-to-string [pre]
  (cond (= 10 pre) "=:"
        (= 1 pre) "1:"
        :else "2:"))

(defn item-to-result-string [[count chr pre]]
  (str (pre-to-string pre) (repeat-char-count-times count chr)))

(defn char-frequencies->map [cf]
  (zipmap (map first cf) (map second cf)))

(defn mix-items [fs1 fs2 chr]
  (let [fs1-count (fs1 chr 0)
        fs2-count (fs2 chr 0)]
    (cond (> fs1-count fs2-count) [fs1-count chr 1]
          (= fs1-count fs2-count) [fs1-count chr 10]
          :else [fs2-count chr 2])))

(defn mix [s1 s2]
  (let [ss1 (get-lower-case-chars s1)
        ss2 (get-lower-case-chars s2)
        common-chars (set/union (set ss1) (set ss2))
        fs1 (->> (get-frequencies-of-common-chars common-chars ss1)
                 (sort-by first)
                 (char-frequencies->map))
        fs2 (->> (get-frequencies-of-common-chars common-chars ss2)
                 (sort-by first)
                 (char-frequencies->map))]
    (->> common-chars
         (map (partial mix-items fs1 fs2))
         (filter (fn [[cnt _ _]] (> cnt 1)))
         (sort comparer)
         (map item-to-result-string)
         (str/join #"/"))))
