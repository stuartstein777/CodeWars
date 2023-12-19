identification division.
program-id. blood-moon.
data division.
linkage section.
01  r           pic 9(5).
01  result      pic 9(10)v9(4).
procedure division using r result.

    MULTIPLY r BY r GIVING result.
    DIVIDE result BY 4 GIVING result.

end program blood-moon.
