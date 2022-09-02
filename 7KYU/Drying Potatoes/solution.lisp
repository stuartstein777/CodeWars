(defpackage #:challenge/solution
  (:use #:cl)
  (:export #:potatoes))
(in-package #:challenge/solution)

(defun potatoes (p0 w0 p1)
   (round (floor (* w0 (/ (- 100 p0) (- 100 p1))))))