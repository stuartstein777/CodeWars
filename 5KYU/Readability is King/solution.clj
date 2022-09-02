(ns readability-is-king
  (require [clojure.string :as str]))


(defn is-vowel? [c]
  (not (nil? (#{\a \e \i \o \u \A \E \I \O \U} c))))


(defn flesch-kincaid [text]
  (let [sentences (str/split (str/lower-case text) #"[\.!?]")
        words      (->> (mapcat #(str/split % #" ") sentences)
                        (remove #(= "" %))
                        (vec))
        vowel-groups (map #(partition-by is-vowel? %) words)
        vowel-counts (reduce + 0 (map #(reduce (fn [acc curr]
                                                 (if (some #{\a \e \i \o \u} curr)
                                                   (inc acc)
                                                   acc)) 0 %) vowel-groups))]
    (prn sentences)
    (prn words)
    (prn vowel-counts)
    (- (+ (* 0.39 (/ (count words) (count sentences)))
          (* 11.8 (/ vowel-counts (count words))))
       15.59)))