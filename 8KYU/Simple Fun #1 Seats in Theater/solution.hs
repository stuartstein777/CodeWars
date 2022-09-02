module BlockSeats where

seatsBlocked :: Int -> Int -> Int -> Int -> Int
seatsBlocked tot_cols tot_rows col row =  ((tot_cols+1) - col) * (tot_rows - row)