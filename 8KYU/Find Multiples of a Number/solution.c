#include <stddef.h>

typedef unsigned int uint;

void find_multiples (uint n, uint limit, size_t *count, uint multiples[])
{
  int c = 0;
  for(int i = n; i <= limit; i+=n)
  {
     multiples[c] = i;
     c++;
  }
	*count = c;
}