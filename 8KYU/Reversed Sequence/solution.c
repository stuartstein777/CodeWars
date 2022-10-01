#include <stdlib.h>

unsigned short *reverse_seq(unsigned short num)
{
   
   unsigned short *res = malloc(num * sizeof(short));
   for(int i = num; i > 0; i--)
   {
      res[num-i] = i;
   }
   return res;
}