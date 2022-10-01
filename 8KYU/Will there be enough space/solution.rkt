#lang racket

(provide enough)

(define (enough cap on wait)
  (if (<= (+ on wait) cap)
      0
      (- wait (- cap on))))
