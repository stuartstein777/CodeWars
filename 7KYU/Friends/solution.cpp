#include <math.h>

int friends(int n){
  return n <= 1
    ? 0
    : ceil(log(n) / log(2)) -1;
}