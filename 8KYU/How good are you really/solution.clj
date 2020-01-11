(ns kata.how-good-are-you)
(defn better_than_average [class_points your_points]
 (let [class-avg (quot (reduce + class_points) (count class_points))]
   (if (> your_points class-avg)
     true
     false)))