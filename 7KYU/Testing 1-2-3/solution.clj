(ns line-numbers)

(defn number [lines]
  (loop [numbered []
         to-number lines
         current-line 1]
    (if (empty? to-number)
      numbered
      (recur (conj numbered (str current-line ": " (first to-number))) (rest to-number) (inc current-line)))))