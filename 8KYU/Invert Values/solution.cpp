#include <vector>

std::vector<int> invert(std::vector<int> values)
{
  std::vector<int> inverted; 
  
  for(int n : values) {
    inverted.push_back(-n);
  }
  return inverted;
}