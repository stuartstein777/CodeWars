#include <vector>
using namespace std;

int minSum (vector<int>passed)
{
  sort(passed.begin(), passed.end());
  int size = passed.size() - 1;
  int p = 0;
  for(int i = 0; i <= size/2; i++)
  {
     p = p + (passed[i] * passed[size-i]);
  }
  return p; 
}