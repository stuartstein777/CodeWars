def is_leap_year(year : Int32): Bool
    year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)
end