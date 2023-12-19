#include <stdbool.h>
#include <stddef.h>

bool include(const int* arr, size_t size, int item)
{
    for(size_t i = 0; i < size; i++)   {
      if(arr[i] == item)
        return true;
    }
    return false;
}