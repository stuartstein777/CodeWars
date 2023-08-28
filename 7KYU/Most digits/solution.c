#include <stddef.h>
#include <stdio.h>

int count_digits(int n) {
  if(n < 0) n *= -1;
  int digits = 0;
  while(n > 0) {
    digits++;
    n /= 10;
  }
  return digits;
}

int find_longest(int *numbers, size_t numbers_size)
{
    int longest = 0;
    int longest_digit_count = 0;
  
    for(size_t i = 0; i < numbers_size; i++) {
      int digit_count = count_digits(numbers[i]);
      
      if(digit_count > longest_digit_count) {
        longest = numbers[i];
        longest_digit_count = digit_count;
      }
    }
  
    return longest;
}