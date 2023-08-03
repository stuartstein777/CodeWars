char *correct(char *string) {
  for(int i = 0; string[i] != '\0'; i++) {
    if(string[i] == '5')
      string[i] = 'S';
    if(string[i] == '0')
      string[i] = 'O';
    if(string[i] == '1')
      string[i] = 'I';
  }
  return string;
}