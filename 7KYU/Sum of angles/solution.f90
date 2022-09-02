module Solution
  implicit none
contains
  integer pure function angle(n)
    integer, intent(in) :: n
    angle = (n-2)*180
  end function angle
end module Solution