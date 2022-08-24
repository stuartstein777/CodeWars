#include <vector>
#include <numeric>
#include <functional>

int grow(std::vector<int> nums) {
  return std::accumulate(nums.cbegin(), nums.cend(), 1, std::multiplies<int>{});
}
