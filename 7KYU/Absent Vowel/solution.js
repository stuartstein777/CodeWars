function absentVowel(x){
  if(x.toLowerCase().indexOf('a') == -1)
      return 0;
  else if(x.toLowerCase().indexOf('e') == -1)
      return 1;
  else if(x.toLowerCase().indexOf('i') == -1)
     return 2;
  else if(x.toLowerCase().indexOf('o') == -1)
     return 3;
  else if(x.toLowerCase().indexOf('u') == -1)
     return 4;
}