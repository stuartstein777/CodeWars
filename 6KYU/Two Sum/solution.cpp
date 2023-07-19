std::pair<std::size_t, std::size_t> two_sum(const std::vector<int>& numbers, int target) {
  size_t len = numbers.size();
  
  for(size_t i = 0; i < len-1; i++) {
    for(size_t j = i+1; j < len; j++) {
      if(numbers[i]+numbers[j] == target) {
        return {i, j};
      }
    }
  }
  
  return {0, 0};
}