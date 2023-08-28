#include <stdbool.h>

unsigned digit_sum(unsigned number) {
  unsigned sum = 0;
  
  while(number > 0) {
    int n = number % 10;
    number /= 10;
    sum +=n;
  }
  
  return sum;
}

unsigned reverse(unsigned number) {
  unsigned res = number % 10;
  number /= 10;
  while(number > 0) {
    res *= 10;
    int d = number % 10;
    number /= 10;    
    res += d;
  }
  return res;
}

bool number_joy(unsigned number) {
    unsigned sum = digit_sum(number);
    unsigned rev = reverse(sum);
    return sum * rev == number;
}