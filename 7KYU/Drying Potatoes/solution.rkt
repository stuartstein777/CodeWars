#lang racket
(provide potatoes)

(define (potatoes p0 w0 p1)
  (floor (* w0 (/ (- 100 p0) (- 100 p1)))))