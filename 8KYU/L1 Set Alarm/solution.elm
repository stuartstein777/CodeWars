module SetAlarm exposing (setAlarm)

setAlarm : Bool -> Bool -> Bool
setAlarm employed vacation = employed && not vacation