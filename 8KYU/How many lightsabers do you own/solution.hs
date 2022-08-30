module Lightsabers where

howManyLightsabersDoYouOwn :: Num a => [Char] -> a
-- Make some stuff more good here!
howManyLightsabersDoYouOwn name 
                        | name == "Zach" = 18
                        | name /= "Zach" = 0
                        