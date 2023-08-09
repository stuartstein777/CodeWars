#include <string>

unsigned int strCount(const std::string& word, char letter){
   int count = 0;
  int i = 0;
  while(word[i] != '\0') {
    if(word[i] == letter) {
      count ++;
    }
    i++;
  }
  return count;
}