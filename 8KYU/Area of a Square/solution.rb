def square_area(arc)
    side = ((arc * 4) / Math::PI) / 2
    (side * side).round(2)
  end