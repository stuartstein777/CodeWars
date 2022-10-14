#include <inttypes.h>
#include <stddef.h>

void powers_of_two (size_t n, uint64_t powers[n + 1])
{
     for(size_t i = 0; i <= n; i++) {
       powers[i] = pow(2, i);
     }
}