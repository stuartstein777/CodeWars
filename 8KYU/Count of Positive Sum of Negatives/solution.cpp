#include <vector>

std::vector<int> countPositivesSumNegatives(std::vector<int> input)
{
    if(input.size() == 0) return std::vector<int>{};
  
    int cnt = 0;
    int sum = 0;
  
    for(size_t i = 0; i < input.size(); i++) {
      if(input[i] <= 0)
         sum += input[i];
      else
         cnt++;
    }
  
    return std::vector<int>{ cnt, sum };
}