#include <stddef.h>

int sum(const int array[], size_t start, size_t end) {
  int sum = 0;
  for(size_t i = start; i <= end; i++) {
    sum += array[i];
  }
  return sum;
}

int max_sum(size_t a, const int array[a], size_t r, const size_t ranges[r][2]) {
 
  int max = sum(array, ranges[0][0], ranges[0][1]);
  
  for(size_t i = 1; i < r; i++) {
     size_t start = ranges[i][0];
     size_t end = ranges[i][1];
    
     int cs = sum(array, start, end);
     if(cs > max) {
       max = cs;
     }
  }
  return max; 
}