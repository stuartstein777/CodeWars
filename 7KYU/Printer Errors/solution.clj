(ns printer.core)

(defn printer-error [s]
  (str (count (filter #{\n \o \p \q \r \s \t \u \v \w \x \y \z} s))
       "/"
       (count s)))