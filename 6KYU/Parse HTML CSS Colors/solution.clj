(ns parse-html-color.core
  (:require [parse-html-color.preset :refer [preset-colors]]
            [clojure.string :as str]))

(defn parse-hex [h n]
  (let [b (->> (partition n h)
               (map (partial apply str)))]
    {:r (Integer/parseInt (first b) 16)
     :g (Integer/parseInt (second b) 16)
     :b (Integer/parseInt (last b) 16)}))

(defn parse-html-color [hex]
  (println hex)
  (cond (and (str/starts-with? hex "#") (= 7 (count hex))) (parse-hex (rest hex) 2)
        (and (str/starts-with? hex "#") (= 4 (count hex))) (parse-hex (str (apply str (repeat 2 (second hex)))
                                                                           (apply str (repeat 2 (nth hex 2)))
                                                                           (apply str (repeat 2 (nth hex 3)))) 2)
        :else (parse-html-color (preset-colors (str/lower-case hex)))))