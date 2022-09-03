#include <vector>

std::vector<int> humanYearsCatYearsDogYears(int humanYears) {
  
  int dogAge = 0;
  int catAge = 0;
  
  for(int i = 1; i <= humanYears; i++) {
    if(i == 1) {
      dogAge += 15;
      catAge += 15;
    }
    else if(i == 2) {
      dogAge += 9;
      catAge += 9;
    }
    else {
      dogAge += 5;
      catAge += 4;
    }
  }
  return std::vector<int>{humanYears, catAge, dogAge};
}