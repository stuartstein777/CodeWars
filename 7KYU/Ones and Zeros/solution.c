#include <stddef.h>

unsigned binary_array_to_numbers(const unsigned *bits, size_t count)
{
  int res = 0;
  int m = 1;
  for(int i = count-1; i >= 0; i--)
  {
    if(bits[i] == 1)
      res+= m;
      
    m *= 2;
  }
  
  return res;  
}