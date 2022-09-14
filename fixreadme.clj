(require '[clojure.string :as str])

(let [stripped (->> "README.md"
                    slurp
                    str/split-lines
                    (drop-while (fn [l] (= l "")))
                    rest
                    (drop-while (fn [l] (= l ""))))
      fixed-badge (subs (first stripped) 1)
      fixed (str/join "\n" (concat [fixed-badge] (rest stripped)))]
  (spit "README.md" fixed))

