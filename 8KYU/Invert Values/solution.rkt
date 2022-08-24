#lang racket

(provide invert)

(define (invert values)
  (map - values))
