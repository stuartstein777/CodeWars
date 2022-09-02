module Its.Timmys.Fault.Again where

createList :: Int -> [Int]
createList n = filter (<= n) [1..n]