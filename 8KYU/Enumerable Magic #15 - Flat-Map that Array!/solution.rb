def flat_map list, &block
  list.collect_concat{|f| block.call f}
end