;; ==============================================
;; Swap two items in a list
;;
(defn swap [v i1 i2]
  (assoc v i2 (v i1) i1 (v i2)))

(swap [:o :# :#] 0 1)