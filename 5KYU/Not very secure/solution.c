#include <stdbool.h>
#include <string.h>

bool alphanumeric(const char* string) {

    size_t length = strlen(string);
    if(length == 0) return false;
    size_t i = 0; 
    for (; i < length; i++) {
      int c = (int)string[i];
      
      if(c < 48 ||
        (c > 57 && c < 65) ||
        (c > 90 && c < 97) ||
        c > 122) {
          return false;
      }
    }
  return true;

}