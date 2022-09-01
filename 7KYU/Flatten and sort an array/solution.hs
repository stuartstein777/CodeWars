module FlatSort where
import Data.List

flatSort :: [[Int]] -> [Int]
flatSort xs = sort (concat xs)