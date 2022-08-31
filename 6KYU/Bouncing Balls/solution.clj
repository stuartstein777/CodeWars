(ns bouncing-balls.core)

(defn bouncing-balls
  ([h bounce window]
   (if (or (neg? h) (zero? h) (>= window h) (not (< 0 bounce 1)))
     -1
     (bouncing-balls h bounce window 0)))
  ([h bounce window bounces]
   (if (<= h window)
     (inc (* 2 (dec bounces)))
     (recur (* bounce h) bounce window (inc bounces)))))