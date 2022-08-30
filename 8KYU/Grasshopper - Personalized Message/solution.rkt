#lang racket

(provide greet)

(define (greet name owner)
  (if (eq? name owner)
    "Hello boss"
    "Hello guest"))
