#include<string.h>

char *double_char (const char *string, char *doubled)
{
  *doubled = '\0'; // write to doubled
  int len = strlen(string);
  int i = 0;
  for(i=0; i < len; i++) {
    doubled[i*2] = string[i];
    doubled[i*2+1] = string[i];
  }
  doubled[i*2] = '\0';
  return doubled;
}