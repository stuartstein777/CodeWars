#lang racket

(provide move-hero)

(define (move-hero position roll)
  (+ position (* 2 roll)))
