#include <stddef.h>

int find_odd (size_t length, const int array[length])
{
   int x = array[0];
  
   for(int i = 1; i < length; i++) {
     x = x ^ array[i];
   }
   return x;
}