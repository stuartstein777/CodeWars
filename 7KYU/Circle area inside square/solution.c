#include <math.h>

extern const double Pi; // preloaded value of Pi

double square_area_to_circle_area (double square_area)
{
    double radius = sqrt(square_area) / 2;
  
	  return Pi * (radius * radius);
}