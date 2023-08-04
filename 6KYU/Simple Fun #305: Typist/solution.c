unsigned typist(const char *string) {

  int capsOn = 0;
  unsigned clicks = 0;
  
  for(int i = 0; string[i] != '\0'; i++) {
     if(string[i] >= 'A' && string[i] <= 'Z' && capsOn == 0) {
       capsOn = 1;
       clicks += 2;
     } else if(string[i] >= 'a' && string[i] <= 'z' && capsOn == 1) {
       capsOn = 0;
       clicks += 2;
     } else {
       clicks ++;
     }
  }
  
  return clicks;
}