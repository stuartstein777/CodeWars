#include <stddef.h>

size_t number_of_rectangles(size_t m, size_t n) {
    return (((m+1) * m) / 2) * (((n+1) * n) / 2);
}