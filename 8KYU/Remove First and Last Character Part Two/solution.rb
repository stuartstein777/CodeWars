def array(string)
    s = string.split(",")[1...-1]
    
    if s != nil and s != []
      return s.join(" ")
    else
      return nil
    end
end