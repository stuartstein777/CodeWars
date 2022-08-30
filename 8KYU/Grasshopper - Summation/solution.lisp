(defpackage #:challenge/solution
  (:use #:cl)
  (:export #:summation))
(in-package #:challenge/solution)

(defun summation (n) 
  (/ (* n (+ n 1)) 2))
