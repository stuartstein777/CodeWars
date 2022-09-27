function updatelight(current)
    if(current == "green")
      return "yellow"
    elseif(current == "yellow")
      return "red"
    else
      return "green"
    end
end