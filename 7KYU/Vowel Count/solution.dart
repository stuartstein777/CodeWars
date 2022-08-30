import "dart:core";

int getCount(String inputStr){
  return RegExp("[aeiou]").allMatches(inputStr).length;
}