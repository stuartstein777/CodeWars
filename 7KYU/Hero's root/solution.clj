(ns intsqroot.core)

(defn int-rac
  ([n initial-guess] (int-rac n initial-guess 1))
  ([n initial-guess cnt]
   (let [r (Math/floor (*' 0.5 (+ initial-guess (/ n initial-guess))))]
     (if (< (Math/abs (- r initial-guess)) 1)
       cnt
       (recur n r (inc cnt))))))
