#include <stdbool.h>

bool checkAlive(int health){
  if (health <= 0) {
    return false;
  } else {
    return true;
  }
}