function pell(n) {

    if (n <= 2) {
      return BigInt(n);
    }
    
    let a = BigInt(1);
    let b = BigInt(2);
    
    for(i = 3; i <= n; i++) {
      c = BigInt(2) * b + a
      a = b
      b = c
    }
    
    return BigInt(b);
}