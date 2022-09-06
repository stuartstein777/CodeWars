#include <vector>

using namespace std; 

int findSmallest(vector <int> list)
{
   int smallest = list[0];
  
    for(int i = 1; i < list.size(); i++)
    {
      if(list[i] < smallest)
        smallest = list[i];
    }
    return smallest;
}