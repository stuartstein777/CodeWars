#include <utility>
#include <vector>

unsigned int number(const std::vector<std::pair<int, int>>& busStops){
  int bus = 0;
  
  for(auto i = 0; i < busStops.size(); i++) {
    bus = bus + busStops[i].first - busStops[i].second;
  }
  
  return bus;
}