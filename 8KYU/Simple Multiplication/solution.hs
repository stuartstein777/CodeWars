module Codewars.MichM.SimpleMultiplication where

simpleMultiplication :: Int -> Int
simpleMultiplication n = if n `mod` 2 == 0 then n * 8 else n * 9