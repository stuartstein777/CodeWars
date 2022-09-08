#include <string>

std::string bumps(std::string road){
  int total = 0;
  for(int i = 0; i < road.length(); i++)
  {
      if(road[i] != '_')
        total=total+1;
  }
  if(total <= 15)
    return "Woohoo!";
  else
    return "Car Dead";
}