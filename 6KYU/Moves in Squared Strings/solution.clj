(ns opstrings1.core
  (require [clojure.string :as str]))

(defn rot [s]
  (->> (str/split-lines s)
       (map #(apply str (reverse %)))
       (reverse)
       (str/join "\n")))

(defn selfie-and-rot [s]
  (str  (->> (str/split-lines s)
             (map #(apply str % (apply str (repeat (count %) "."))))
             (str/join "\n"))
        "\n"
        (->> (str/split-lines s)
             (map #(apply str (apply str (repeat (count %) ".")) (reverse %)))
             (reverse)
             (str/join "\n"))))

(defn oper [fct s]
  (fct s))