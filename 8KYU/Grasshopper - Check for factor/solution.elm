module CheckForFactor exposing (checkForFactor)

checkForFactor : Int -> Int -> Bool
checkForFactor b f = (remainderBy f b) == 0