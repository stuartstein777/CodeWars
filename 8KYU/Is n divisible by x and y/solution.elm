module Kata exposing (isDivisible)

isDivisible : Int -> Int -> Int -> Bool
isDivisible n x y = (remainderBy x n == 0) && (remainderBy y n == 0)