#include <stddef.h>

unsigned stanton_measure(size_t length, const unsigned array[length]) {

    int ones = 0;
  
    for(int i = 0; i < length; i++) {
      if(array[i] == 1){
        ones++;
      }        
    }
  
    int res = 0;
    for(int i = 0; i < length; i++) {
      if(array[i] == ones) {
        res++;
      }
    }
    return res;
}