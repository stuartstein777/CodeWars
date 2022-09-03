module TwiceAsOld where
twice_as_old :: Int -> Int -> Int
twice_as_old d s = abs(((d - s) * 2) - d)