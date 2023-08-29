def range_bit_count(a, b)
    (a..b).map {|n| n.to_s(2).count("1")}.sum        
end