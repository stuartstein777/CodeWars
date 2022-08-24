module Kata (isDivisible) where

isDivisible :: Int -> Int -> Int -> Bool
isDivisible n x y  = rem n x == 0 && rem n y == 0