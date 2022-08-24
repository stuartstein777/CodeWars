#lang racket

(provide grow)

(define (grow lst)
  (foldl * 1 lst))
