#lang racket

(provide past)
 
(define (past h m s)
  (+ (* s 1000) (* m 60000) (* h 3600000)))