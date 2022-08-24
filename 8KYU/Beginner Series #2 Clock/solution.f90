module Solution
  implicit none
contains
  integer pure function past(h, m, s)
    integer, intent(in) :: h, m, s
    past = s * 1000 + m * 60000 + h * 3600000
  end function past
end module Solution