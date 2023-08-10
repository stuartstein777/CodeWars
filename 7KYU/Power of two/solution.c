#include <stdbool.h>

bool power_of_two(const int n) {
    
  return n == 0 ? false : (n & (n - 1)) == 0;   

}