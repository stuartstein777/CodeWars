#include <string>

using namespace std;

int getCount(const string& s){
   int count = 0, c = 0;
    while(s[c] != '\0')
    {
      if(s[c] == 'a' || s[c] == 'e' || s[c] == 'i' || s[c] == 'o' || s[c] == 'u')
      {
        count++;
      }
      c++;
    }
    return count;
}