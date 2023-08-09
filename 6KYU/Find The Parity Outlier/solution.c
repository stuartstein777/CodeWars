#include <stdlib.h>

int find_outlier(const int *values, size_t count)
{
    if(((values[0] &1) == (values[1] &1)) && ((values[2] &1) != (values[0] &1))) {
      return values[2];
    } else if(((values[0] &1) != (values[1] &1)) && ((values[0] &1) != (values[2] &1))) {
      return values[0];
    } else if(((values[0] &1) != (values[1] &1)) && ((values[0] &1) == (values[2] &1))) {
      return values[1];
    }
  
    for(size_t i = 3; i < count; i++) {
      if ((values[i] &1) != (values[0]&1)) {
        return values[i];
      }
    }
    return 0;
}