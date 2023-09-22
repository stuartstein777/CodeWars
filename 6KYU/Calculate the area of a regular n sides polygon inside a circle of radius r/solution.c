#include <math.h>

double PI = 3.141592653589793; // Use this value as pi in your calculations if necessary
double area_of_polygon_inside_circle(double circle_radius, int number_sides) {
  return round((((circle_radius * circle_radius) * number_sides) / 2.0) * (sin((PI * 2.0)/ number_sides)) * 1000) / 1000;
}
