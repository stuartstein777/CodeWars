#include <string>

std::string bool_to_word(bool value)
{
  if(value)
    return "Yes";
  return "No";
}