module Solution
  implicit none
contains
  integer pure function move(pos, roll) result (res)
    integer, intent(in) :: pos, roll
    res = pos + 2 * roll
  end function move
end module Solution