def count list, &block
  list.count{|i| block.call i}
end