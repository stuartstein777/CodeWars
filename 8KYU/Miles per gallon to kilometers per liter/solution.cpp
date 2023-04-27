#include <math.h>
double converter(int mpg)
{
    return round(((mpg * 1.609344) / 4.54609188) * 100.0) / 100.0;
}