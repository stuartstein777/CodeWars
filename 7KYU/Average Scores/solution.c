#include <stddef.h>
#include <stdio.h>
int average(const int *values, size_t count)
{
  float total = 0;
  for(int i = 0; i < count; i++)
  {
    total += values[i];
  }
  total = total / count;
  return (int)(total < 0 ? (total - 0.5) : (total + 0.5));
}