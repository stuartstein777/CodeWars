#lang racket

(provide number-to-string)

(define (number-to-string z)
  (~v z))
