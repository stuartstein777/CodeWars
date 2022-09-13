#include <vector>

int even_last(std::vector<int> nums) {
  int total = 0;
  
  if(nums.size() == 0) return 0;
  
  for(auto i = 0; i < nums.size(); i+=2) {
    total += nums[i];
  }
  return total * nums[nums.size()-1];
}