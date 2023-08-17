#include <string>

int solve(const std::string &s)
{
    int largest = 0;
    int current = 0;
  
    for(int i = 0; i < s.length(); i++) {
      char c = s[i];
      if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') {
        if(current > largest) {
          largest = current;
        }
        current = 0;
      } else {
        current += c - 96;
      }
    }
  
    return current > largest ? current : largest;
}