#include <stddef.h> // NULL

const char* how_much_i_love_you(int nb_petals) {
  const char *phrases[6];
  phrases[0] = "I love you";
  phrases[1] = "a little";
  phrases[2] = "a lot";
  phrases[3] = "passionately";
  phrases[4] = "madly";
  phrases[5] = "not at all";
  
  return phrases[(nb_petals -1) % 6];
}