module Theater exposing (seats)

seats : Int -> Int -> Int -> Int -> Int
seats nCols nRows col row =
  ((nCols+1) - col) * (nRows - row)