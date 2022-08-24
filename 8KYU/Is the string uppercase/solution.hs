module Codewars.Kata.IsUpperCase where
import Data.Char(toUpper)

isUpperCase :: String -> Bool
isUpperCase str = str == map toUpper str