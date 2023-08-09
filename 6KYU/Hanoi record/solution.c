#include <stdio.h>

unsigned long long pow2(unsigned x) {
  unsigned long long result = 2;
  
  for(unsigned i = 1; i < x; i++) {
    result *= 2;
  }
  
  return result;
}

unsigned long long hanoi(unsigned disks) {
    if(disks == 0) return 0;
    return pow2(disks) -1;
}