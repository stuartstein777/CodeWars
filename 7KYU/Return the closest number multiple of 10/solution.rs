fn closest_multiple_of_10(n: u32) -> u32 {
    let rem = n % 10;
    if (rem < 5) {
      return n - rem;
    }
    return n + 10 - rem;
 }
 