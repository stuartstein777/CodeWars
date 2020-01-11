(ns marks)

(defn get-average [marks]
  (quot (reduce + marks) (count marks)))