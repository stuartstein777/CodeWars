#include <stdbool.h>

bool xo (const char* str)
{
  int exes = 0;
  int ohs = 0;
  
  int i = 0;
  while(str[i] != 0)
  {
    if(str[i] == 'o' || str[i] == 'O')
      ohs++;
    if(str[i] == 'x' || str[i] == 'X')
      exes++;
    i++;
  }
  
  return exes == ohs;
}