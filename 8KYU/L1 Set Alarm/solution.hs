module Codewars.AlarmUtils where

-- note you have to use GHC 7.10.3

setAlarm :: Bool -> Bool -> Bool
setAlarm employed vacation = employed && not vacation
