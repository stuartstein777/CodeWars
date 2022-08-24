#include <stdbool.h>

// 97 122

bool is_uppercase(const char *source)
{
  for(int i = 0; i < strlen(source); i++)
  {
      int c = source[i];
    
      if(c >= 97 && c <= 122)
        return false;
  }
  return true;  
}