#lang racket

(provide upcase?)

(define (upcase? str)
  (string=? str (string-upcase str)))