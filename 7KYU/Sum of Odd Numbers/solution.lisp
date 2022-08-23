(defpackage #:challenge/solution
  (:use #:cl)
  (:export #:row-sum-odd-numbers))
(in-package #:challenge/solution)

(defun row-sum-odd-numbers (n) 
  (* n n n))