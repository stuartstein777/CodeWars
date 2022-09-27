function isVowel(x) {
    if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u') {
      return true;
    }
    return false;
}
  
function getCount(str) {
    var cnt = 0;
    
    for(var i = 0; i < str.length; i++) {
      if(isVowel(str[i]))
        cnt++;
    }
    return cnt;
}