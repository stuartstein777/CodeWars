#include <stddef.h>

int between_extremes(size_t length, const int numbers[length]) {

    int smallest = numbers[0];
    int largest = numbers[0];
  
    for(size_t i = 1; i < length; i++) {
      if(numbers[i] < smallest) {
        smallest = numbers[i];
      }
      if(numbers[i] > largest) {
        largest = numbers[i];
      }
    }
  
    return largest - smallest;

}