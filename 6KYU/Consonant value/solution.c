#include<string.h>

int solve(const char *str_in) {

    int largest = 0;
    int current = 0;
  
    for(int i = 0; i < strlen(str_in); i++) {
      char c = str_in[i];
      if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') {
        if(current > largest) {
          largest = current;
        }
        current = 0;
      } else {
        current += c - 96;
      }
    }
    return current > largest ? current : largest;
}