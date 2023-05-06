fn perimeter(n: u64) -> u64 {
    let mut total:u64 = 0;
    let mut a:u64 = 4;
    let mut b:u64 = 4;
    
    for x in 0..=n {
      total += a;
      let c:u64 = a+b;
      a = b;
      b = c;
    }
      
    return total;
  }