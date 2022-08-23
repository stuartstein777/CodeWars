module NumberRect where

numberOfRectangles :: Int -> Int -> Int
numberOfRectangles m n = (((m+1) * m) `div` 2) * (((n+1) * n) `div` 2);