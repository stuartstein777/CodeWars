;; ==============================================
;; Split a number into its digits.
;;
(->> 942 str (map (comp read-string str)))

