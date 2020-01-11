(ns clojure.phone)
(defn create-phone-number [nums]
  (str  "(" (apply str (take 3 nums)) ") "
            (apply str (subvec nums 3 6)) "-"
            (apply str (subvec nums 6 10))))