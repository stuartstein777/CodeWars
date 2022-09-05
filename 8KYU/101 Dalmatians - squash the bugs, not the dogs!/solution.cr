def how_many_dalmatians(n)
    dogs = ["Hardly any", "More than a handful!", "Woah that's a lot of dogs!", "101 DALMATIANS!!!"];
    
    if n <= 10
      return dogs[0]
    elsif n <= 50
      return dogs[1]
    elsif n == 101
      return dogs[3]
    else
      return dogs[2]
    end
  end