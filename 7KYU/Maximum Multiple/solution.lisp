(defpackage #:challenge/solution
  (:use #:cl)
  (:export #:max-multiple))
(in-package #:challenge/solution)

(defun max-multiple (divisor bound)
  (- bound (mod bound divisor)))