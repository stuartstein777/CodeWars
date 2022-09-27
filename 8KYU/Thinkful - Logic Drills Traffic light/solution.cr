def update_light(current)
    if current == "green"
      return "yellow"
    elsif current == "yellow"
      return "red"
    else
      return "green"
    end
end