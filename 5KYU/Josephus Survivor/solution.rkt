#lang racket

(provide josephus-survivor)

(define (josephus-it r i n k)
    (if (= i (+ 1 n))
        (+ 1 r)
        (josephus-it (modulo (+ r k) i) (+ 1 i) n k)))

(define (josephus-survivor n k)
  (josephus-it 0 1 n k))