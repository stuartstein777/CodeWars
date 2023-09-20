#include <stddef.h>

int is_vowel(char c) {
  return c == 'a' || c =='e' || c == 'i' || c == 'o' || c == 'u' ? 1 : 0;
}

size_t solve(const char *str_in) {

  size_t max = 0;
  size_t cur = 0;
  
  for(size_t i = 0; str_in[i] != '\0'; i++) {
    if(is_vowel(str_in[i]) == 1) {
      cur++;
    } else {
      if(cur > max) {
        max = cur;
      }
      cur = 0;
    }
  }
  
  return cur > max ? cur : max;

}