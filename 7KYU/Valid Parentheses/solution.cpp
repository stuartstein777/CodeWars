#include <string>

bool validParentheses(const std::string& str) {
  int open = 0;
  int i = 0;
  while(str[i] != '\0') {
    if(str[i] == '(') {
      open++;
    }
    else {
      open--;
      if(open < 0)
        return false;
    }
    i++;
  }
  return open == 0;
}