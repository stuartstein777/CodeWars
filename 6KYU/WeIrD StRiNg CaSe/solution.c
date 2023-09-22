char *to_weird_case (char *string)
{
// mutate string and return it
  int wi = 0;
  int i = 0;
  for(i = 0; string[i] != '\0'; i++) {
    if (string[i] != ' ') {
      if(wi % 2 == 0 && string[i] >= 97 && string[i] <= 122) {
        string[i] = string[i] - 32; // make it uppercase
      } else if (wi % 2 != 0 && string[i] >= 65 && string[i] <= 90) {
        string[i] = string[i] + 32;
      }
      wi ++;
    } else {
      wi = 0;
    }
  }
  string[i] = '\0';
	return string;
}