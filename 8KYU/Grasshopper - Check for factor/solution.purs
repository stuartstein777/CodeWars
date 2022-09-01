module Kata (checkForFactor) where

import Prelude

checkForFactor :: Int -> Int -> Boolean
checkForFactor base factor = base `mod` factor == 0