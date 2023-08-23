#lang racket

(provide max-multiple)

(define (max-multiple d b)
  (- b (modulo b d)))