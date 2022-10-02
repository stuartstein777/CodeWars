#include <stddef.h>

int invite_more_women(int *arr, size_t count)
{
    int total = 0;
    for(int i = 0; i < count; i++) {
      total += arr[i];
    }
    return total > 0;
}