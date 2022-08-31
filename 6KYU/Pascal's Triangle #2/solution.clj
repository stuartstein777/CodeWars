(ns clojure.pascal)

(defn get-row [n previous]
  (loop [i 0
         row []]
    (if (= i n)
      (concat row [1])
      (if (= 0 i)
        (recur (inc i) (concat row [1]))
        (recur (inc i) (concat row [(+ (nth previous i) (nth previous (dec i)))]))))))

(defn pascal [n]
  (loop [triangle [[1]]
         row 1]
    (prn triangle "::" row)
    (if (= n row)
      triangle
      (recur (conj triangle (get-row row (last triangle))) (inc row)))))