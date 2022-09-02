(ns stockbroker.core
  (:require [clojure.string :as str]))

(defn is-double? [n]
  (some? (re-matches #"\d+(\.\d{1,3})" (str n))))

(defn is-integer? [n]
  (some? (re-matches #"(\d+)" (str n))))

(defn order-string->order-map [order]
  (let [[ticker quantity price status] (str/split order #" ")]
    {:ticker   ticker
     :quantity (read-string quantity)
     :price    (read-string price)
     :status   (if (some? status) status "")}))

(defn validate-order [order]
  (let [valid-quantity (is-integer? (:quantity order))
        valid-price (is-double? (:price order))
        valid-status (and (not= "" (:status order)) (str/includes? "BS" (:status order)))]
    (assoc order :valid (and valid-quantity valid-status valid-price))))

(defn invalid-order->string [order]
  (str (:ticker order) " "
       (:quantity order) " "
       (:price order)
       (if (= "" (:status order))
         (str " ")
         (str " " (:status order) " "))))

(defn balance [ords]
  (if (= "" ords)
    "Buy: 0 Sell: 0"
    (let [orders (->> (str/split ords #",")
                      (map str/trim)
                      (map order-string->order-map)
                      (map validate-order))
          valid-orders (filter #(true? (:valid %)) orders)
          invalid-orders (filter #(false? (:valid %)) orders)
          summary (reduce (fn [acc o]
                            (if (= "B" (:status o))
                              [(+ (first acc) (* (:quantity o) (:price o))) (second acc)]
                              [(first acc) (+ (second acc) (* (:quantity o) (:price o)))]))
                          [0 0] valid-orders)]
      (str "Buy: " (format "%.0f" (if (zero? (first summary))
                                    0.0
                                    (first summary)))
           " Sell: " (format "%.0f" (if (zero? (second summary))
                                      0.0
                                      (second summary)))
           (if (not= (count invalid-orders) 0)
             (str "; Badly formed " (count invalid-orders) ": "
                  (str/join ";" (map invalid-order->string invalid-orders))
                  ";"))))))