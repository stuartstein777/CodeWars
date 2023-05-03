#include <stddef.h>

size_t str_count(const char *str, char letter) {
  int count = 0;
  int i = 0;
  while(str[i] != '\0') {
    if(str[i] == letter) {
      count ++;
    }
    i++;
  }
  return count;
}