(ns balance.core
  (require [clojure.string :as str]))

(defn to-check-entry [s]
  (let [splits (str/split (str/replace s #"[^a-zA-Z\d\s\.]" "") #" ")]
    {:chq-no   (read-string (first splits))
     :category (second splits)
     :amount   (read-string (nth splits 2))}))

(defn line-summary [[balance report] {:keys [chq-no category amount]}]
  (let [new-balance (- balance amount)]
    [new-balance (str report \newline (str (format "%03d" chq-no) " " category " " (format "%.2f" amount) " Balance " (format "%.2f" new-balance)))]))

(defn balance [book]
  (prn book)
  (let [lines (str/split-lines (str/replace book #"[^a-zA-Z\d\s\.]" ""))
        opening-bal (read-string (first lines))
        entries (->> (rest lines)
                     (remove #(= "" %))
                     (map to-check-entry))
        total-expenses (->> entries
                            (map :amount)
                            (reduce +))
        average-expense (/ total-expenses (count entries))]
    (str (second (reduce line-summary [opening-bal (str "Original Balance: " (format "%.2f" opening-bal))] entries))
         (str "\nTotal expense  " (format "%.2f" total-expenses))
         (str "\nAverage expense  " (format "%.2f" average-expense)))))