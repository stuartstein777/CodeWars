char *makeUpperCase (char *string) {
  for(int i = 0; string[i] != '\0'; i++) {
    if(string[i] >= 'a' && string[i] <= 'z')
      string[i] = string[i] - 32;
  }
  return string;
}
