#include <string.h>
using namespace std;

string get_middle(string input) 
{
    if(input.length() % 2 == 0) {
      auto half = input.length() / 2;
      return input.substr(half-1, 2);
    } else {
      int half = (input.length() / 2);
      return input.substr(half, 1);
    }
}