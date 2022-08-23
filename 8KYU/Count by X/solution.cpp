#include <vector>
std::vector<int> countBy(int x,int n){
  std::vector<int> res;
  
  for(int i = 1; i <= n; i++) {
    res.push_back(i * x);
  }
  return res;
}