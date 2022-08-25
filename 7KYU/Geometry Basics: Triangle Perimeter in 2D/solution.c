#include<stdlib.h>
#include <math.h>

typedef struct { double x, y;   } Point;
typedef struct { Point a, b, c; } Triangle;

double triangle_perimeter(Triangle t) {
    double ab = sqrt(fabs(t.a.x - t.b.x) * fabs(t.a.x - t.b.x) + fabs(t.a.y - t.b.y) * fabs(t.a.y - t.b.y));
    double bc = sqrt(fabs(t.b.x - t.c.x) * fabs(t.b.x - t.c.x) + fabs(t.b.y - t.c.y) * fabs(t.b.y - t.c.y));
    double ac = sqrt(fabs(t.a.x - t.c.x) * fabs(t.a.x - t.c.x) + fabs(t.a.y - t.c.y) * fabs(t.a.y - t.c.y));
    return ab + bc + ac;
}