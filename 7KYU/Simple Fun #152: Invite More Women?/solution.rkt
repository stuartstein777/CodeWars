#lang racket

(provide invite-more-women)

(define (invite-more-women l)
  (> (apply + l) 0))