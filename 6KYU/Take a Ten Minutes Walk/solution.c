#include <stdbool.h>
#include <stdio.h>
#include <string.h>
// input is a null-terminated string

bool isValidWalk(const char *walk) {
    int we = 0; int sn = 0;
    int len = strlen(walk);
    for(int i = 0; i < len; i++) {
      if(walk[i] == 'w') {
        we++;
      } else if(walk[i] == 'e') {
        we--;
      } else if(walk[i] == 'n') {
        sn++;
      } else if(walk[i] == 's') {
        sn--;
      } 
    }
    return len == 10 && we == 0 && sn == 0;
}