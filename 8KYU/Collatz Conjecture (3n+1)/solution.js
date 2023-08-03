var hotpo = function(n){
    var c = 0;
  
    while(n != 1) {
      c++;
      if (n % 2 == 0) {
         n /= 2;
      }
      else {
        n = 3 * n + 1;
      }
    }
  
    return c;
    
}