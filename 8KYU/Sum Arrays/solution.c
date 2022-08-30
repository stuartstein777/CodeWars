#include <stddef.h>

int sum_array(const int *values, size_t count)
{
  int total = 0;
  for(int i = 0; i < count; i++)
  {
    total = total + values[i];
  }
  return total;
}