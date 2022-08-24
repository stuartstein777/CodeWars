module Kata exposing (past)

past : Int -> Int -> Int -> Int
past h m s = s * 1000 + m * 60000 + h * 3600000