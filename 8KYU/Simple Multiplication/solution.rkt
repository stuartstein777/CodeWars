#lang racket

(provide simple-multiplication)

(define (simple-multiplication z)
  (if (even? z)
      (* z 8)
      (* z 9)))

