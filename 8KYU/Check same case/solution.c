const int UPPER = 1;
const int LOWER = 2;
const int NOT_LETTER = 3;

int is_ascii_char(int a) {
  if(a >= 65 && a <= 90)
    return UPPER;
  if(a >= 97 && a <= 122)
    return LOWER;
  return NOT_LETTER;
}

int same_case (char a, char b)
{
  int ca = is_ascii_char((int)a);
  int cb = is_ascii_char((int)b);
  
  if((ca == UPPER && cb == UPPER) || (ca == LOWER && cb == LOWER)) {
    return 1;
  } else if((ca == UPPER && cb == LOWER) || (ca == LOWER && cb == UPPER)) {
    return 0;
  }	
  return -1;
}