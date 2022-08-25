#lang racket

(provide bool->word)

(define (bool->word b)
  (if b "Yes" "No"))
