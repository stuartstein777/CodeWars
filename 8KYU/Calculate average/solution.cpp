#include <vector>
#include <numeric>
  
double calcAverage(const std::vector<int>& values){
  return std::accumulate(values.begin(), values.end(), 0.0) / values.size();
}