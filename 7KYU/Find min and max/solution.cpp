#include <utility>
#include <vector>

std::pair<long, long> get_min_max(const std::vector<long>& seq) {
  long smallest = seq[0];
  long largest = seq[0];
  
  for(size_t i = 0; i < seq.size(); i++)  {
    if(seq[i] > largest) {
      largest = seq[i];
    }
    if(seq[i] < smallest) {
      smallest = seq[i];
    }
  }
  return {smallest, largest};
}
