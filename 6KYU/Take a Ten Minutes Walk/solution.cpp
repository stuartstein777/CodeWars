#include<vector>

bool isValidWalk(std::vector<char> walk) {
  int y = 0; int x = 0;
  
  for(int i = 0; i < walk.size(); i++) {
    if(walk[i] == 'n') {
      y++;
    } else if(walk[i] == 's') {
      y--;
    } else if(walk[i] == 'e') {
      x++;
    } else if(walk[i] == 'w') {
      x--;
    }
  }
  return walk.size() == 10 && y == 0 && x == 0;
}