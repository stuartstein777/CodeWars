#include <stdbool.h>

bool tidyNumber(int number)
{
   int n = number % 10;
   number /= 10;
  
   while(number != 0) {
     int d = number % 10;
     number /= 10;
     if(d > n)
       return false;   
     n = d;
   }
   return true; 
}