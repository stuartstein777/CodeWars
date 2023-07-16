#include <stdbool.h>

bool cube_checker(int volume, int side) {
  return ((side > 0 && volume > 0) && (volume == side * side * side));
}