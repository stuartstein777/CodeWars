#include <map>
#include <string>

std::map<char, unsigned> count(const std::string& string) {
  std::map<char, unsigned> result;  
  
  for(unsigned long i = 0; i < string.length(); i++) {
    char c = string[i];
    if (result.find(c) == result.end()) {
      result.insert({c, 1});
    } else {
      result[c] ++;
    }
  }
  return result;
}