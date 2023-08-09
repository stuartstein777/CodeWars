#include <stddef.h>

unsigned short max_diff(size_t n, const short array[n]) {

  if(n == 0) return 0;
  
  int smallest = array[0];
  int largest = array[0];
    
  for(int i = 1; i < n; i++) {
    if(array[i] < smallest) {
      smallest = array[i];
    } else if(array[i] > largest) {
      largest = array[i];
    }
  }
  
  return largest - smallest;

}