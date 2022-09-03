#include <vector>
using namespace std;
vector<int> quadratic(int x1,int x2){
   return std::vector<int> {1, -x2 - x1, -x1 * -x2};
}