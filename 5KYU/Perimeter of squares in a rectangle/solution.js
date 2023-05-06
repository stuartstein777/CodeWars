function perimeter(n) {
  
    let total = 0;
    let a = 4;
    let b = 4;
    
    for(i = 0; i <= n; i++) {
      total += a;
      let c = a + b;
      a = b;
      b = c;
    }
    return total;
}