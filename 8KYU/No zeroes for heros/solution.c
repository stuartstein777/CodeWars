int no_boring_zeros(int n) {

    while(n % 10 == 0 && n != 0) {
      n /= 10;
    }
    
    return n;
}