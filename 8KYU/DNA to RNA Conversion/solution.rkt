#lang racket

(provide dna->rna)

(define (dna->rna dna)
  (string-replace dna "T" "U"))