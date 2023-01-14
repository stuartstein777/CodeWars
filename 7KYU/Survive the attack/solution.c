#include <stdbool.h>
#include <stddef.h>

int sum_array(size_t len, const unsigned *arr) {
  int sum = 0;
  
  for(size_t i = 0; i < len; i++) {
    sum += arr[i];
  }
  
  return sum;
}

bool block(size_t a_len, const unsigned *attackers,
           size_t d_len, const unsigned *defenders) {

    if(a_len == 0) {
      return true;
    }
  
    if(d_len == 0) {
      return false;
    }
    size_t biggest = a_len > d_len ? a_len : d_len;
    int surviving_attackers = 0;
    int surviving_defenders = 0;
    for(size_t i = 0; i < biggest; i++) {
      if(i > a_len && i < d_len) {
        surviving_defenders++;
      } else if(i >= d_len && i < a_len) {
        surviving_attackers++;
      } else if(attackers[i] > defenders[i]) {
        surviving_attackers++;
      } else if(defenders[i] > attackers[i]) {
        surviving_defenders++;
      }
    }
    if(surviving_defenders == surviving_attackers) {
      int attackers_initial = sum_array(a_len, attackers);
      int defenders_initial = sum_array(d_len, defenders);
      
      return defenders_initial >= attackers_initial;
    }
  
    return surviving_defenders >= surviving_attackers;
}