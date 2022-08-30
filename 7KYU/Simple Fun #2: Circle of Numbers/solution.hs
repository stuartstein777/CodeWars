module SF2 where

circleOfNumbers :: Int -> Int -> Int
circleOfNumbers n fst =  (fst + (n `div` 2)) `mod` n