#include <stddef.h>

typedef struct { size_t i, j; } coords;

coords bug_in_apple(size_t m, size_t n, const char apple[m][n]) {

    int x = -1;
    int y = -1;
    coords sol;
  
    for(size_t mi = 0; mi < m; mi++) {
      for(size_t ni = 0; ni < n; ni++) {
        if(apple[mi][ni] == 'B') {
          
          sol.i = mi;
          sol.j = ni;
          return sol;
        }
      }
    }
    return sol;
}