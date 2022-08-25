def quarter_of(month)
    case month
      when 1 .. 3
        1
      when 4 .. 6
        2
      when 7 .. 9
        3
      when 10..12
        4
    end
  end