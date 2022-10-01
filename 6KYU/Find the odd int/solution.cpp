#include <vector>

int findOdd(const std::vector<int>& numbers){
  int x = 0;
  
   for(int i = 0; i < numbers.size(); i++) {
     x ^= numbers[i];
   }
   return x;
}