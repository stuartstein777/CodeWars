def swap_adjacent_bits(n)
    n.to_s(2)
     .rjust(32, "0")
     .chars
     .each_slice(2)
     .map {|n| n.join("")}
     .map {|s| s.reverse}
     .join("")
     .to_i(2)
end