#include <stddef.h>

size_t count_pixels(size_t k) {
    if(k == 1) return 11;
    return (k + 2) + 2 + ((4 * k)-4) + (2 * k) + 2 + k;
}