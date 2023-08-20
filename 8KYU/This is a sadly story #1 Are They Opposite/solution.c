#include <stdbool.h>
#include <string.h>

bool is_opposite(const char *s1, const char *s2) {
    int s1len = strlen(s1);
    int s2len = strlen(s2);
  
    if(s1len == 0 || s2len == 0 || s1len != s2len) return false; 
  
    for(int i = 0; i < s1len; i++) {
      if(s1[i] != s2[i] + 32 && s1[i] != s2[i]-32) {
        return false;
      }
    }
    return true;
}