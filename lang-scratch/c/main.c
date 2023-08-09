#include <math.h>
#include <stdbool.h>
#include <stdio.h>

int countDigits(int num) {
  int cnt = 0;
  while(num != 0) {
    cnt++;
    num /= 10;
  }    
  return cnt;
}

bool narcissistic(int num)
{
   int digitCnt = countDigits(num);
   int digits[digitCnt];
  
   int dc = digitCnt;
   while(dc-- != 0) {
     digits[dc] = num % 10;
     num /=10;
   }
  
  int n = 0;
  for(int i = 0; i < digitCnt; i++) {
    printf("%d ^ %d\n", digits[i], digitCnt);
    n += pow(digits[i], digitCnt);
  }
  
  return n == num;
}