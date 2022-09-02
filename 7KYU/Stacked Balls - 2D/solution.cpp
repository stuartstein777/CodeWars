#include <math.h>
double stack_height_2d(int layers)
{
    return layers == 0
      ? 0.0
      : sqrt(pow((layers-1.0), 2) - pow(((layers-1.0)/2.0), 2))+1.0;
}