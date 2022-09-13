bool XO(const std::string& str)
{
  int exes = 0;
  int ohs = 0;
  
  for(auto i = 0; i < str.length(); i++) {
    if(str[i] == 'o' || str[i] == 'O')
      ohs++;
    if(str[i] == 'x' || str[i] == 'X')
      exes++;
  }
  return exes == ohs;
}