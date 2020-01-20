;; ===============================
;; Dates
;;
;; Various functions around creating / parsing / modifying dates.
;; ===============================

;; Creating a date and adding days to it
(-> (java.time.LocalDate/parse "2016-01-01") (.plusDays days) str)

