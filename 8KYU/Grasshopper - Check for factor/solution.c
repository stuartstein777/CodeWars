#include <stdbool.h>

bool check_for_factor(int base, int factor) {
  return base % factor == 0;
}