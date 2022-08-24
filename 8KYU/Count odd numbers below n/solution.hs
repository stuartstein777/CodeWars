module OddCounter where

oddCount :: Int -> Int 
oddCount n 
         | even n = div n 2
         | otherwise = div (n-1) 2