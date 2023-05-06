module CheckFactor where

checkForFactor :: Int -> Int -> Bool
checkForFactor base factor = base `mod` factor == 0