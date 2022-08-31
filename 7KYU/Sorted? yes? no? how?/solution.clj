(ns kata.is-sorted-and-how)

(defn sorted-and-how? [sq]
  (cond (apply > sq) "yes, descending"
        (apply < sq) "yes, ascending"
        :else "no"))
