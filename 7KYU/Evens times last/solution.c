#include <stddef.h>

int even_last(const int arr[], size_t z) {
  int total = 0;
  
  if(z == 0) return 0;
  
  for(int i = 0; i < z; i+=2) {
    total += arr[i];
  }
  return total * arr[z-1];
}