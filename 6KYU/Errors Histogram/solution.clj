;; In a factory a printer prints labels for boxes. The printer uses colors which, for the sake of simplicity, are named with
;; letters from a to z (except letters u, w, x or z that are for errors).
;;
;; The colors used by the printer are recorded in a control string. For example a control string would be aaabbbbhaijjjm meaning 
;; that the printer used three times color a, four times color b, one time color h then one time color a... and so on.
;;
;; Sometimes there are problems: lack of colors, technical malfunction and a control string is produced e.g.
;; uuaaaxbbbbyyhwawiwjjjwwxym where errors are reported with letters u, w, x or z.
;;
;; You have to write a function hist which given a string will output the errors as a string representing a histogram of the 
;; encountered errors.
;;
;; The format of the textual histogram is:
;;  u  n     ** where u is the error code, n is the number of errors and n stars.
;;
;; Each column should be aligned: e.g.
;;
;; s="uuaaaxbbbbyyhwawiwjjjwwxymzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz"
;; hist(s):
;;	u  2     **
;;	w  5     *****
;;	x  2     **
;;	z  31    *******************************"
;;

(ns hist-error.core
  (:require [clojure.string :as str]))

(defn build-line [k v]
  (str k "  " v (apply str (repeat (- 6 (count (str v))) " ")) (apply str (repeat v "*"))))

(defn hist [s]												;; s: "uuaaaxbbbbyyhwawiwjjjwwxymzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz" 
  (->> (filter #(#{\u \w \x \z} %) s)						;; "uuxwwwwwxzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz"
       (frequencies)										;; {u 2, x 2, w 5, z 31}
       (reduce-kv #(conj %1 (build-line %2 %3)) [])			;; ["u  2     **" "x  2     **" "w  5     *****" "z  31    *******************************"]
       (sort)												;; ("u  2     **" "w  5     *****" "x  2     **" "z  31    *******************************")
       (str/join "\r")))									;; "u  2     **/rw  5     *****/rx  2     **/rz  31    *******************************"
	   
;; When printed:
;; u  2     **
;; w  5     *****
;; x  2     **
;; z  31    *******************************

