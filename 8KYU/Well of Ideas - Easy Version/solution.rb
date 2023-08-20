def well(x)
    
    good_ideas = (x.select do |n| n == "good" end).length

    if good_ideas > 2
      return "I smell a series!"
    elsif good_ideas >= 1
      return "Publish!"
    else
      return "Fail!"
    end
end

