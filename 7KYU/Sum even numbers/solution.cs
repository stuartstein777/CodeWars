Copy to clipboard#include <stddef.h>

int sum_even_numbers(size_t length, const double seq[length]) {

  int res = 0;
  
  for(size_t i = 0; i < length; i++) {
    if ((int)seq[i] == seq[i] && (int)seq[i] % 2 == 0) {
      res += seq[i];
    }
  }

  return res;  
}