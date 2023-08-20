def count_positives_sum_negatives(lst)
    if lst.length() == 0
      return []
    else
      pos = (lst.select do |n| n > 0 end).length()
      neg = (lst.select do |n| n < 0 end).sum()
      
      return [pos, neg]
    end
end
  