#include <vector>
#include <numeric>

bool betterThanAverage(std::vector<int> classPoints, int yourPoints) {
  int totalScore = 0;
  int avg = accumulate(classPoints.begin(), classPoints.end(), 0) / classPoints.size();
   
   return (ulong)yourPoints > avg;
}