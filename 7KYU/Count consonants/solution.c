#include <stddef.h>
#include <string.h>

size_t consonant_count(const char *string) {

    int l = strlen(string);
    size_t cnt = 0;
  
    for(int i = 0; i < l; i++) {
      char c = string[i];
      
      if((c >= 'b' && c <= 'z' && c != 'e' && c != 'i' &&
         c != 'o' && c != 'u') ||
         (c >= 'B' && c <= 'Z' && c != 'E' && c != 'I' &&
         c != 'O' && c != 'U'))  {
        cnt++;
      }
    }
    return cnt;

}