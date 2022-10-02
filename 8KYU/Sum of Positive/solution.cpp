#include <vector>

int positive_sum (const std::vector<int> arr){
  int total = 0;
  
  for(int i = 0; i < arr.size(); i++) {
    if(arr[i] > 0) {
      total += arr[i];
    }
  }
  
  return total;
}