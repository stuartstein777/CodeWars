def two_highest(list)
    p list
    if(list.empty?)
      []
    elsif(!list.kind_of?(Array))
      false
    else
      list.uniq.sort[-2, 2].reverse
    end
end  