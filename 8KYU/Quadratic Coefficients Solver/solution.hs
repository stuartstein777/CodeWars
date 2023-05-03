module CoefficientsOfTheQuadraticEquation (quadratic) where

quadratic :: Int -> Int -> (Int,Int,Int)
quadratic x1 x2 = (1, 0 - x2 - x1, (0-x1) * (0-x2))
