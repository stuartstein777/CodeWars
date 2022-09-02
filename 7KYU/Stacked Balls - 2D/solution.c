#include <math.h>

double stack_height_2d(int n)
{
    if(n == 0)
      return 0.0;
    else
      return sqrt(pow((n-1.0), 2) - pow(((n-1.0)/2.0), 2))+1.0;      
}