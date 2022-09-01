module AreaPerimeter where

areaOrPerimeter :: Double -> Double -> Double
areaOrPerimeter l w = if l == w then
                        l*w
                      else
                        2*l + 2*w