#lang racket

(provide circle-of-numbers)

(define (circle-of-numbers n first-number)
  (modulo (+ first-number (/ n 2)) n))