#include <stdbool.h>

bool two_are_positive(int a, int b, int c) {
    return (a > 0 && b > 0 && c <= 0) ||
           (a > 0 && b <= 0 && c > 0) ||
           (a <= 0 && b > 0 && c > 0);
}