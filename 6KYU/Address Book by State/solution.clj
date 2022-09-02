(ns bystate.core
  (require [clojure.string :as str]))

(def states {"AZ"  "Arizona"
             "CA" "California"
             "ID" "Idaho"
             "IN" "Indiana"
             "MA" "Massachusetts"
             "OK" "Oklahoma"
             "PA" "Pennsylvania"
             "VA" "Virginia"})

(defn vec->map [[friend address city-and-state]]
  (let [city              (str/trim (subs city-and-state 0 (- (count city-and-state) 2)))
        state             (str/trim (subs city-and-state (- (count city-and-state) 2)))]
    (prn state)
    {:name  friend
     :address (str/trim address)
     :state   (states state)
     :city    city}))

(defn friend->address-string [{:keys [name address state city]}]
  (str "..... " name " " address " " city  " " state "\n"))

(defn by-state [addresses]
  (let [friends-by-state (->> (str/split-lines addresses)
                              (map #(str/split % #","))
                              (map vec->map)
                              (sort-by (juxt :state :name))
                              (group-by :state))]
    friends-by-state
    (->> (for [state (keys friends-by-state)]
           [state (->> (map friend->address-string (friends-by-state state))
                       (apply str))])
         (map #(str " " (first %) "\n" (second %)))
         (apply str)
         (str/trim))))
