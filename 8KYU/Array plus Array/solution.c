#include <stddef.h>

long sum(const int *a, size_t na) {
  long sum = 0;
  
  for(size_t i = 0; i < na; i++) {
      sum += a[i];
   }
   return sum;
}

long arr_plus_arr(const int *a,  const int *b, size_t na, size_t nb)
{
  return sum(a, na) + sum(b, nb);
}