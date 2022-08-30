#include <stddef.h>

long sum_two_smallest_numbers(size_t n, const int numbers[n]) {

    int smallest = -1;
    int second_smallest = -1;
  
    for(int i = 0; i < n; i++){
      int c = numbers[i];
      if(smallest == -1 || c <= smallest) {
        second_smallest = smallest;
        smallest = c;
      } else if(second_smallest == -1 || c <= second_smallest) {
        second_smallest = c;
      }
    }
  
  return (long)smallest + second_smallest;

}