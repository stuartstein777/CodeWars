#include <stdbool.h>

bool am_i_afraid(const char *day, int num)
{
    return (strcmp(day, "Monday") == 0 && num == 12) ||
          (strcmp(day, "Tuesday") == 0 && num > 95) ||
          (strcmp(day, "Wednesday") == 0 && num == 34) ||
          (strcmp(day, "Thursday") == 0 && num == 0) ||
          (strcmp(day, "Friday") == 0 && num % 2 == 0) ||
          (strcmp(day, "Saturday") == 0 && num == 56) ||
          (strcmp(day, "Sunday") == 0 && (num == 666 || num == -666));
}
