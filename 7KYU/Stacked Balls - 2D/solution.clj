(ns kata)
(defn ** [n]
  (* n n))

(defn stack-height-2d [n]
  (if (zero? n)
    0
    (+ 1 (Math/sqrt (- (** (- n 1.0))
                       (** (/ (- n 1.0) 2.0)))))))