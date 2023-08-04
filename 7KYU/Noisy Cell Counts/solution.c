#include <stddef.h>

//  don't allocate memory for the resulting array
//  assign values to preallocated pointer *output

void cleaned_counts(size_t length, const unsigned data[length], unsigned output[length]) {

    output[0] = data[0];
    unsigned curBiggest = output[0];
  
    for(size_t i = 1; i < length; i++) {
      if(data[i] > curBiggest) {
        curBiggest = data[i];
      }
      
      if(data[i] < curBiggest) {
        output[i] = curBiggest;
      } else {
        output[i] = data[i];
      }
      
    }

}