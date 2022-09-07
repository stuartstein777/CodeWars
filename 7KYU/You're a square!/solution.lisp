(defpackage #:challenge/solution
  (:use #:cl)
  (:export #:is-square?))
(in-package #:challenge/solution)

(defun is-square? (n)
  (if (< n 0)
      NIL
      (= 0 (mod (sqrt n) 1))))