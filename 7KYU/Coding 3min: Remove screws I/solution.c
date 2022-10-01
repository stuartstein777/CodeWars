#include <string.h>

unsigned sc (const char *screws)
{
   size_t len = strlen(screws);
   char last = screws[0];
   int time = 1;
   for(size_t i = 1; i < len; i++) {
     if(screws[i] == last) {
        time++;
     } else {
        last = screws[i];
        time+=6;
     }
   }

   return time + (len-1);
}