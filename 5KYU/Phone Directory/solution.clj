(ns phonedir.core
  (:require [clojure.string :as str]))

(defn parse-entry [entry num]
  (println entry)
  (let [name (first (re-seq #"\<.+\>" entry))]
    (str "Phone => " num ", "
         "Name => " (subs name 1 (dec (count name))) ", "
         "Address => " (-> entry
                           (str/replace (str "+" num) "")
                           (str/replace name "")
                           (str/replace #"[^a-zA-Z\d\s\.\-\_]" "")
                           (str/replace #"\s+" " ")
                           (str/replace #"\_" " ")
                           (str/trim)))))
(defn phone [s num]
  (println s)
  (let [[entry & r] (->> s
                         (str/split-lines)
                         (filter #(str/includes? % (str "+" num))))]
    (cond
      r
      (str "Error => Too many people: " num)

      (not entry)
      (str "Error => Not found: " num)

      :else
      (parse-entry entry num))))