#include <stddef.h>

void count_positives_sum_negatives(
  int *values, size_t count, int *positivesCount, int *negativesSum) 
{
  int cnt = 0;
  int sum = 0;
  
  for(size_t i = 0; i < count; i++) {
    if(values[i] <= 0)
      sum += values[i];
    else
      cnt++;
  }
  
  *positivesCount = cnt;
  *negativesSum = sum;
}  