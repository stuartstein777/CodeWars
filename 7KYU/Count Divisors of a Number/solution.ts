export function divisors(n: number) {
    var totalDivisors = 0;
      
      for(var i:number = 1; i <= n; i++) {
        if(n % i == 0) {
          totalDivisors++;
        }
      }
      
      return totalDivisors;
}