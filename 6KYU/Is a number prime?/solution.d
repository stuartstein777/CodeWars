module solution;
import core.math;
export bool isPrime(int n) 
{
    if(n < 2) return false;
  
    for(int i = 2; i <= sqrt(n+0.0); i++)
         if(n % i == 0)
           return false;
    
     return true;
}
