/* The first parameter argc will indicate
 how many additional arguments were passed to the function.
 All arguments will be of type int
*/
#include<stdarg.h>
int sum (int argc, ...)
{
   va_list valist;
   int res = 0;
   va_start(valist, argc);

   for(int i=0; i<argc; i++)
   {
      res = res + va_arg(valist, int);
   }

   va_end(valist);

   return res;
}