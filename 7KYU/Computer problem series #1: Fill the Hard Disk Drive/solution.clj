(ns kata.save)

(defn save [sizes hd]
  (count (filter #(<= % hd) (reductions + sizes))))