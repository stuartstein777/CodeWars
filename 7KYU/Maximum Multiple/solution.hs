module MaxMult where

maxMultiple :: Int -> Int -> Int
maxMultiple d b = b - (b `mod` d)