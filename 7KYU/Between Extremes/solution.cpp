#include <vector>

int betweenExtremes(const std::vector<int>& numbers) {
  int smallest = numbers[0];
  int largest = numbers[0];
  
  for(size_t i = 1; i < numbers.size(); i++) {
    if(numbers[i] < smallest) {
      smallest = numbers[i];
    }
    if(numbers[i] > largest) {
      largest = numbers[i];
    }
  }
  
  return largest - smallest;
}