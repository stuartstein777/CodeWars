(ns potatoes.core)

(defn potatoes [p0 w0 p1]
  (int (Math/floor (* w0 (/ (- 100 p0) (- 100 p1))))))