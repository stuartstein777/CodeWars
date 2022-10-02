#include <stdbool.h>

bool pair_of_shoes (int n, const int shoes[n][2])
{
	  int leftRight = 0;
    int sizes = 0;
  
    for(int i = 0; i < n; i++)
    {
       if(shoes[i][0] == 0)
       {
          leftRight++;
          sizes+=shoes[i][1];
       }
       if(shoes[i][0] == 1)
       {
          leftRight--;
          sizes-=shoes[i][1];
       }
    }
    return leftRight == 0 && sizes == 0;
}