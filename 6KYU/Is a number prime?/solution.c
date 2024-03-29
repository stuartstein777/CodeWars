#include <stdbool.h>

bool is_prime(int n)
{
    if(n < 2) return false;
  
    for(int i = 2; i <= sqrt(n); i++)
         if(n % i == 0)
           return false;
    
     return true;
}