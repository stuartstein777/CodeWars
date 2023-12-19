#define M_PI acos(-1.0)
#include "math.h"
double blood_moon(int o) {
  double sq_acdf = o * o;
  double cf = sqrt((o * o) + (o * o));
  double c_acdf = M_PI * cf * cf;
  double semi_ahf = ((c_acdf - sq_acdf)/4.0);
  double agf = M_PI * o * o;
  
  return (agf / 2) - semi_ahf;
}