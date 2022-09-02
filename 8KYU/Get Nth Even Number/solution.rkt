#lang racket

(provide nth-even)

(define (nth-even n)
  (* 2 (- n 1)))