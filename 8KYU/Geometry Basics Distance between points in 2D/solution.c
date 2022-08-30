#include <stdlib.h>
#include <math.h>

typedef struct Point {
    double x;
    double y;
} point;

double distance_between_points(point a, point b) {

    float dx = fabs(a.x - b.x);
    float dy = fabs(a.y - b.y);
    return sqrt((dx * dx ) + (dy * dy));
}