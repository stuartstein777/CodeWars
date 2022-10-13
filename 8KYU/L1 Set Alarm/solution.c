#include <stdbool.h>
#include <stdlib.h>

bool set_alarm(bool employed, bool vacation) {
  return employed && !vacation;
}