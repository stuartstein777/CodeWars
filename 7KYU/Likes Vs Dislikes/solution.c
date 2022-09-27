#include <stddef.h>

enum button { NOTHING, LIKE, DISLIKE };

enum button like_or_dislike (size_t n, const enum button events[n])
{
  enum button current_state = NOTHING;
  
  for(int i = 0; i < n; i++)
  {
    if(events[i] == current_state) {
      current_state = NOTHING;
    } 
    else
    {
      current_state = events[i];
    }
  }
  
  return current_state;
  
}