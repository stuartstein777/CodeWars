// For c the function should return false if no non consecutive numbers are found
// It should return true if one is found and the pointer arg first set to the value

#include <stdbool.h>

bool firstNonConsecutive (const int arr[], const int length, int *first) {
  int a = arr[0];
  for(int i = 1; i < length; i++) {
    if(arr[i] - a > 1) {
      *first = arr[i];
      return true;
    }
    a = arr[i];
  }
  return false;
}