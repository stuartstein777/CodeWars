#include <stddef.h>

size_t collatz(unsigned long long int n) {

    size_t res = 1;
  
    while(n != 1){
      res = res + 1;
      if(n % 2 == 0) {
        n /= 2;
      }
      else {
        n = n * 3 + 1;
      }
    }
  
    return res;

}