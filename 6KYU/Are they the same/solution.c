#include <stdbool.h>
#include <stdlib.h>

int cmp (const void * a, const void * b) {
   return ( *(int*)a - *(int*)b );
}

bool comp(const int *a, const int *b, size_t n)
{ 
    qsort(a, n, sizeof(int), cmp);
    qsort(b, n, sizeof(int), cmp);
  
    for(size_t i = 0; i < n; i++) {
      if(a[i] * a[i] != b[i]) {
        return false;
      }
    }
    return true;
}