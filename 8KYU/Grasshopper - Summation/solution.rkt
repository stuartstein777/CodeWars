#lang racket

(provide summation)

(define (summation n)
  (* n (/ (+ n 1) 2)))
  