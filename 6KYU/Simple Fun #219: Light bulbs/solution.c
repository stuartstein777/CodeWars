#include <stdbool.h>
#include <stdio.h>

void light_bulbs (int len, const bool initial[len], bool final[len], unsigned n)
{
  for(int i = 0; i < len; i++) {
    final[i] = initial[i];
  }

  for(unsigned i = 0; i < n; i++) {
    bool finalWasOn = final[len-1];
    for(unsigned j = len-1; j > 0; j--) {
      if(final[j-1] == 1) {
         final[j] = final[j] ^ 1;
      }
    }
    if(finalWasOn == 1) {
      final[0] = final[0] ^ 1;
    }
  }
}