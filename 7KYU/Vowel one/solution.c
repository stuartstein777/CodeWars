//  don't dynamically allocate memory for return
//  assign results to output, then return output
//  output is preallocated / not null terminated

int isVowel(char c) {
  if(c == 'a' || c == 'e' || c == 'i' || c =='o' || c == 'u' ||
     c == 'A' || c == 'E' || c == 'I' || c =='O' || c == 'U') {
    return 1;
  }
  return 0;
}

char *vowel_one(const char *input, char *output) {

    int i = 0;
    for(i = 0; input[i] != '\0'; i++) {
      if(isVowel(input[i]) == 0) {
        output[i] = '0';
      } else {
        output[i] = '1';
      }
    }
    output[i] = '\0';
    return output;
}