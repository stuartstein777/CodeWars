#lang racket

(provide how-many-light-sabers-do-you-own)

(define (how-many-light-sabers-do-you-own name)
  (if (equal? name "Zach")
    18
    0))