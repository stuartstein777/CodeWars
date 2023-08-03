unsigned int next(unsigned int n) {
  return n % 2 == 0 ? n / 2 : 3 * n + 1;
}
unsigned int hotpo(unsigned int n){
    unsigned int c = 0;
  
    while(n != 1) {
       c++;
       n = next(n);
    }
  
    return c;    
}