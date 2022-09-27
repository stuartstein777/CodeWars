#include <string>

std::string update_light(std::string current) {
  if(current == "red") return "green";
  if(current == "yellow") return "red";
  return "yellow";
}